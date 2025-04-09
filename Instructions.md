## Run a custom Graph API from PowerBI using client credentials

> Step 1
1. Copy the `1. Get-BearerToken` PowerQuery text from the repo.
2. Create a new PowerBI report.
3. Click on `Get Data > Blank Query`.
4. The Power Query Advanced Editor will open, paste the text in the query window.
5. If there are no syntax errors, click Done to close this window.
6. On the right pane window called `Query Settings`, rename `Query1` to `Get-BearerToken`.

![image](https://github.com/user-attachments/assets/52d03164-79cd-4d3e-a23f-a465ce83ddfa)

   
> Step 2
1. Copy the `2. Run-GraphAPI` PowerQuery text from the repo.
2. Right-click under the `Get-BearerToken` query and select `New Query  > Blank Query`
3. Paste the text in the query window.
4. On right-pane window, rename `Query1` to `Run-GraphAPI`.

![image](https://github.com/user-attachments/assets/a41c14b9-863c-45ff-aa6c-74cf86154c00)


> Step 3
1. Click in the top menu `Home > Manage Parameters`.
2. Click New and name the parameter: `TenantID`
3. Choose `Text` as Type.
4. Paste in your tenant ID in the `current value` field.


![image](https://github.com/user-attachments/assets/e98196ec-8bf1-485c-b74a-00f18d9792e1)
