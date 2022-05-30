window.googleOAuth2 = {
    dotnetReference: undefined,
    client: undefined,
    access_token: undefined,
    init: function (dotnetReference, clientId, scopes) {
        window.googleOAuth2.dotnetReference = dotnetReference;

        window.googleOAuth2.client = google.accounts.oauth2.initTokenClient({
            client_id: clientId,
            scope: scopes,
            callback: (tokenResponse) => {
                access_token = tokenResponse.access_token;
                window.googleOAuth2.dotnetReference.invokeMethodAsync('OnGoogleAuthCallback', tokenResponse.access_token).then(_ => { });
            },

        });
    },
    requestToken: function () {
        window.googleOAuth2.client.requestAccessToken();
    }
};