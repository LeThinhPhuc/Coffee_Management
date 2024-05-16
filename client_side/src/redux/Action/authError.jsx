export const HANDLE_AUTH_ERROR = 'HANDLE_AUTH_ERROR';

export const handleAuthError = () => ({
    type: HANDLE_AUTH_ERROR,
    payload: {
        message: 'Unauthorized access - please log in again.'
    }
});