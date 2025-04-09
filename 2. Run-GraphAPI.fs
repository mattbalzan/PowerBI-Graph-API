let
    // Get Bearer Token Using Function 
    Resource = "https://graph.microsoft.com",
    Bearer = #"Get-BearerToken" (TenantID, AppID, SecretID, Resource),
    
    // Define the API endpoint
    apiUrl = "https://graph.microsoft.com/beta/deviceManagement/manageddevices?$select=deviceName,userDisplayName,enrolledByUserPrincipalName,enrolledDateTime,id",

    headers = [
        #"Authorization" = Bearer
    ],

    // Function to get a page of data
    GetPage = (url as text) =>
    let
        response = Json.Document(Web.Contents(url, [Headers=headers])),
        data = response[value],
        nextLink = try response[#"@odata.nextLink"] otherwise null
    in
        [Data = data, NextLink = nextLink],

    // Function to get all pages of data
    GetAllPages = (url as text) =>
    let
        firstPage = GetPage(url),
        allPages = List.Generate(
            () => firstPage,
            each [NextLink] <> null,
            each GetPage([NextLink]),
            each [Data]
        ),
        combinedData = List.Combine(allPages)
    in
        combinedData,

    // Get all data from the API
    allData = GetAllPages(apiUrl),

    // Convert the data to a table
    dataTable = Table.FromList(allData, Splitter.SplitByNothing(), null, null, ExtraValues.Error),
    #"Expanded Column1" = Table.ExpandRecordColumn(dataTable, "Column1", {"deviceName", "userDisplayName", "enrolledByUserPrincipalName", "enrolledDateTime", "id"}, {"Column1.deviceName", "Column1.userDisplayName", "Column1.enrolledByUserPrincipalName", "Column1.enrolledDateTime", "Column1.id"})
in
    #"Expanded Column1"
