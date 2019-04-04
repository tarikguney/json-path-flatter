# JSON Path Flatter
It has a simple mechanism to work. It gets any JSON file and flats them.

For instance:

```
{
    ccn: 'abc123',
    orgId: 90210,
    orgName: 'Enhanced Test Client',
    crimeId: 151,
    agencyCrimeTypeId: 'agencyCrimeTypeId',
    agencyCrimeTypeDescription: 'agencyCrimeTypeDescription',
    offenseStatute: 'offenseStatute',
    attempted: true,
    crimeSeverity: 'crimeSeverity',
    reportDate: '2019-02-06T04:56:08+0000',
    offenseDate: '2019-02-06T01:36:08+0000',
    lastDateTime: '2019-02-06T01:57:38+0000',
    trueNarrative: 'trueNarrative',
    location: {
      address: '123 main',
      city: 'Our Town',
      state: 'MI',
      postalCode: '84444',
      county: 'Our County',
      country: 'Out
    }
 }
 ```
 
 will be 
 
 ```
{
  "from": "ccn",
  "to":""
},
{
  "from": "orgId",
  "to":""
},
{
  "from": "orgName",
  "to":""
},
{
  "from": "location.city",
  "to":""
},
{
  "from": "location.state",
  "to":""
},
{
  "from": "location.postalCode",
  "to":""
}
```

I am using it for mapping purposes. I need to be able to flat out the path information of each item in a JSON file so that I can do key/value mapping.
