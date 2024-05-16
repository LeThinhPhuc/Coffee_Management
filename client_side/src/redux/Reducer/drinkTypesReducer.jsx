// redux/Reducer/drinkTypesReducer.js
import {
    FETCH_DRINK_TYPES_REQUEST,
    FETCH_DRINK_TYPES_SUCCESS,
    FETCH_DRINK_TYPES_FAILURE,
  } from "../Action/drinkTypeActions";

  
  const initialState = {
    loading: false,
    data: [],
    error: null, // change to null to be consistent with prop type
  };
  
  const drinkTypesReducer = (state = initialState, action) => {
    switch (action.type) {
      case FETCH_DRINK_TYPES_REQUEST:
        return {
          ...state,
          loading: true,
        };
      case FETCH_DRINK_TYPES_SUCCESS:
        return {
          loading: false,
          data: action.payload,
          error: null, // reset error on success
        };
      case FETCH_DRINK_TYPES_FAILURE:
        return {
          loading: false,
          data: [],
          error: action.payload,
        };
      default:
        return state;
    }
  };
  
  export default drinkTypesReducer;
  