## Corvallis Bus Server

The backend that powers the best apps for the Corvallis Transit System.

## Prerequisites for running

- Visual Studio 2015
- Azure Account

## Purpose

To have a more convenient way to get real-time information about the free buses in Corvallis.  Data from CTS (basically, huge chunks of XML) is mapped into some more easily-digestable JSON for different use cases.

## User Stories Covered

1. As a student, I want to know when the route I take to school will be at my stop.
2. As a teacher, I want to know when the next bus will be at my stop.
3. As a new resident, I want to see what the routes look like on my devices.

## Disclaimer

We assume no liability for any missed buses.  Buses may be erratic in their arrival behavior, and we cannot control that.

## API Routes

###/transit/static

- Input: None
- Output:

Returns a JSON dictionary containing static route and stop information.  Recommended usage is a one-time download and then local storage on the device.  This will allow for simpler and far less data-intensive calls later.

Url: http://corvallisbus.azurewebsites.net/transit/static

```
{
   "routes":
   {
      "1":
      {
        "path": [
          14244,
          13265,
          ...
        ]
      }
      "2":
      {
        ...
      }
    }
    "stops":
    {
      "10019": 
      {
        "id": 10019,
        "name": "Benton Oaks RV Park",
        "routes": [
          "C3"
        ]
      },
      ...
    }
```

###/transit/eta/

- Input: One or more Stop IDs
- Output:

Returns a JSON dictionary, where they keys are the supplied Stop IDs, and the values are dictionaries.  These dested dictionaries are such that the keys are route numbers, and the values are integers corresponding to the ETA for that route to that stop.  For example, ``"2":[21]"`` means that Route 2 is arriving at the given stop in 21 minutes.

Sample Url: http://corvallisbus.azurewebsites.net/transit/eta/14244,13265

```
{
  "14244": {
    
  },
  "13265": {
    "1": [
      6
    ],
    "2": [
      21
    ],
    "5": [
      22
    ],
    "8": [
      22
    ]
  }
}
```
