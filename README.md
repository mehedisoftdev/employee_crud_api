# Employee CRUD API
<table>
  <tr>
  <td>Techonology</td>
  <td>.NET Core 8.0, C#, Visual Studio 2022</td>
</tr>
</table>
## Documentation of API Endpoints
<table>
  <caption>API EndPoints</caption>
  <tr>
    <th>Description</th>
    <th>End points with short desc</th>
  </tr>
  <tr>
    <td>Base URL</td>
    <td>Not Defined</td>
  </tr>
  <tr>
    <td>Read All Employees</td>
    <td>api/employees/all</td>
  </tr>
  <tr>
    <td>Read Particular Employee </td>
    <td>api/employees?employeeId = 1</td>
  </tr>
  <tr>
    <td>Save Employee</td>
    <td>api/employees/save <br>Employee data should pass with json structure <br>
  <pre>
    {
      "id": 0,
      "name": "string",
      "address": "string"
   }
  </pre>
</td>
  </tr>
  <tr>
    <td>Update Employee </td>
    <td>api/employees/update?employeeId = 1 <br>Employee data should pass with json structure <br>
  <pre>
    {
      "id": 0,
      "name": "string",
      "address": "string"
   }
  </pre>
    </td>
  </tr>
  <tr>
    <td>Delete employee </td>
    <td>api/employees/delete?employeeId = 1</td>
  </tr>
  
</table>
