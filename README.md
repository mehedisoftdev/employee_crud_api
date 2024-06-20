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
<h3>Every end points response</h3>
<table>
  <tr>
    <th>Enpoints</th>
    <th>Response</th>
  </tr>
  <tr>
    <td>
      api/employees/all
    </td>
    <td>
      <pre>
        {
  "isSuccess": true,
  "message": "Data read success",
  "employees": [
    {
      "id": 1,
      "name": "Jhon Doe",
      "address": "Barishal"
    },
    {
      "id": 2,
      "name": "Maimona Akter Ayesha",
      "address": "Gaforgao, Mymenshing"
    },
    {
      "id": 3,
      "name": "Mark Zukerburg",
      "address": "America"
    },
    {
      "id": 4,
      "name": "Karmakor",
      "address": "Rajbari"
    },
    {
      "id": 5,
      "name": "Marki",
      "address": "Canada"
    },
    {
      "id": 6,
      "name": "Muzammel",
      "address": "Chittagong"
    }
  ]
}
      </pre>
    </td>
  </tr>
  <tr>
    <td>api/employees?employeeId=1</td>
    <td>
      <pre>
        {
  "isSuccess": true,
  "message": "Data read success",
  "employees": [
    {
      "id": 1,
      "name": "Jhon Doe",
      "address": "Barishal"
    }
  ]
}
      </pre>
    </td>
  </tr>

   <tr>
    <td>api/employees/save</td>
    <td>
      <pre>
{
  "isSuccess": true,
  "message": "Employee Id: 9 is saved successfully",
  "employees": [
    {
      "id": 9,
      "name": "string",
      "address": "string"
    }
  ]
}
      </pre>
    </td>
  </tr>
  <tr>
    <td>
      api/employees/update?employeeId=1
    </td>
    <td>
      <pre>
        {
  "isSuccess": true,
  "message": "Employee Id: 1 has been successfully updated",
  "employees": [
    {
      "id": 1,
      "name": "string",
      "address": "string"
    }
  ]
}
      </pre>
    </td>
  </tr>
  <tr>
    <td>api/employees/delete?employeeId = 1</td>
    <td>
      <pre>
        {
  "isSuccess": true,
  "message": "Employee Id : 1 has been successfully deleted",
  "employees": [
    {
      "id": 1,
      "name": "string",
      "address": "string"
    }
  ]
}
      </pre>
    </td>
  </tr>
  
</table>
