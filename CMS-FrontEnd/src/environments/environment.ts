// This file can be replaced during build by using the `fileReplacements` array.
// `ng build` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.
export const baseUrl: string = 'https://localhost:7014/';
export const environment = {
  production: false,
  apiUrl: `${baseUrl}api/`,
  token:
    'eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiJjOTA2OGJkOS03OWVlLTRiY2EtYjAwNi1lYTFjN2RjODc5NzMiLCJzdWIiOiJhZG1pbkBtZWFkLWFsc29yYW5pLmNvbSIsImVtYWlsIjoiYWRtaW5AbWVhZC1hbHNvcmFuaS5jb20iLCJ1aWQiOiIwOWRkOTI5NS01NDc3LTQ4MTgtODc1NS1mNzNiZmE2YjZmYzkiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsImV4cCI6MTY2NTEyOTQ0MywiaXNzIjoiQ29sbGVhZ2VNYW5hZ2VtZW50U3lzdGVtX01lYWRfQWxzb3JhbmkiLCJhdWQiOiJDTVNfVXNlcnMifQ.Q_nIumvr7OPt6bW74phm1SpQ_ONF7A_fbheXLJAtXg_bPDRCAK38Hi5RyA0riWA7A7BzvXTq70a_rUD9pi4bAQ',
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/plugins/zone-error';  // Included with Angular CLI.
