# Car Showroom API

- [Car Showroom API](#car-showroom-api)
  - [Create Car](#create-car)
    - [Create Car Request](#create-car-request)
    - [Create Car Response](#create-car-response)
  - [Get Car](#get-car)
    - [Get Car Request](#get-car-request)
    - [Get Car Response](#get-car-response)
  - [Update Car](#update-car)
    - [Update Car Request](#update-car-request)
    - [Update Car Response](#update-car-response)
  - [Delete Car](#delete-car)
    - [Delete Car Request](#delete-car-request)
    - [Delete Car Response](#delete-car-response)

## Create Car

### Create Car Request

```js
POST /cars
```

```json
{
    "brand": "Toyota",
    "model": "Camry",
    "year": 2023,
    "color": "Blue",
    "price": 25000
}
```

### Create Car Response

```js
201 Created
```

```yml
Location: {{host}}/cars/{{id}}
```

```json
{
    {
    "id": "00000000-0000-0000-0000-000000000000",
    "brand": "Toyota",
    "model": "Camry",
    "year": 2023,
    "color": "Blue",
    "price": 25000
}

}
```

## Get Car

### Get Car Request

```js
GET /cars/{{id}}
```

### Get Car Response

```js
200 Ok
```

```json
{
    {
    "id": "00000000-0000-0000-0000-000000000000",
    "brand": "Toyota",
    "model": "Camry",
    "year": 2023,
    "color": "Blue",
    "price": 25000
}

}
```

## Update Car

### Update Car Request

```js
PUT /cars/{{id}}
```

```json
{
    "brand": "Toyota",
    "model": "Camry",
    "year": 2023,
    "color": "Red",
    "price": 26000
}
```

### Update Car Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/cars/{{id}}
```

## Delete Car

### Delete Car Request

```js
DELETE /cars/{{id}}
```

### Delete Car Response

```js
204 No Content
```
