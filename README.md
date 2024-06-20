# Employee CRUD API

## Technology
- .NET Core 8.0, C#, Visual Studio 2022

## API EndPoints

| Description             | Endpoints with Short Description                   |
|-------------------------|----------------------------------------------------|
| Base URL                | Not Defined                                        |
| Read All Employees      | `GET /api/employees/all`                           |
| Read Particular Employee| `GET /api/employees?employeeId=1`                  |
| Save Employee           | `POST /api/employees/save`                         |
| Update Employee         | `PUT /api/employees/update?employeeId=1`           |
| Delete Employee         | `DELETE /api/employees/delete?employeeId=1`        |

## Every endpoint response

### GET /api/employees/all
```json
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
```

### GET /api/employees?employeeId=1
```json
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
```

### POST /api/employees/save
```json
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
```

### PUT /api/employees/update?employeeId=1
```json
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
```

### DELETE /api/employees/delete?employeeId=1
```json
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
```


