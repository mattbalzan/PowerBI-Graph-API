## Run a custom Graph API from PowerBI using client credentials

> Import the Get-BearerToken query
1. Copy the `1. Get-BearerToken` PowerQuery text from the repo.
2. Create a new PowerBI report.
3. Click on `Get Data > Blank Query`.
4. The Power Query Advanced Editor will open, paste the text in the query window.
5. If there are no syntax errors, click Done to close this window.
6. On the right pane window called `Query Settings`, rename `Query1` to `Get-BearerToken`.

![image](https://github.com/user-attachments/assets/83c84ad3-bacc-4c92-aad4-dc4a5d135146)


   
> Import the Run-GraphAPI query
1. Copy the `2. Run-GraphAPI` PowerQuery text from the repo.
2. Right-click under the `Get-BearerToken` query and select `New Query  > Blank Query`
3. Paste the text in the query window.
4. On right-pane window, rename `Query1` to `Run-GraphAPI`.

![image](https://github.com/user-attachments/assets/a41c14b9-863c-45ff-aa6c-74cf86154c00)


> Create the Parameters
1. Click in the top menu `Home > Manage Parameters`.
2. Click New and name the parameter: `TenantID`
3. Choose `Text` as Type.
4. Paste in your tenant ID in the `current value` field.
5. Repeat steps 2-4 for the AppID & SecretID.

![image](https://github.com/user-attachments/assets/634b48b6-d647-457b-b81d-f0a09fb0691e)


