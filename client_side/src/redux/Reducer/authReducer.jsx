// redux/Reducer/authReducer.js
import { LOGIN_SUCCESS, LOGIN_FAILURE } from "../Action/authActions";

const initialState = {
  user: null,
  shops: [],
  error: null,
};

const authReducer = (state = initialState, action) => {
  switch (action.type) {
    case LOGIN_SUCCESS:
      return {
        ...state,
        user: action.payload.user,
        shops: action.payload.shops,
        error: null,
      };
    case LOGIN_FAILURE:
      return {
        ...state,
        error: action.payload,
      };
    default:
      return state;
  }
};

export default authReducer;
