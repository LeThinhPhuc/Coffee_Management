// redux/Action/drinkTypesActions.js
import axios from 'axios';

export const FETCH_DRINK_TYPES_REQUEST = 'FETCH_DRINK_TYPES_REQUEST';
export const FETCH_DRINK_TYPES_SUCCESS = 'FETCH_DRINK_TYPES_SUCCESS';
export const FETCH_DRINK_TYPES_FAILURE = 'FETCH_DRINK_TYPES_FAILURE';

import typeService from '../../services/typeService';

export const fetchDrinkTypesRequest = () => {
  return {
    type: FETCH_DRINK_TYPES_REQUEST,
  };
};

export const fetchDrinkTypesSuccess = (drinkTypes) => {
  return {
    type: FETCH_DRINK_TYPES_SUCCESS,
    payload: drinkTypes,
  };
};

export const fetchDrinkTypesFailure = (error) => {
  return {
    type: FETCH_DRINK_TYPES_FAILURE,
    payload: error,
  };
};

export const fetchDrinkTypes = () => {
  return (dispatch) => {
    dispatch(fetchDrinkTypesRequest());
    typeService.getAll()
      .then((response) => {
        const drinkTypes = response.data;
        dispatch(fetchDrinkTypesSuccess(drinkTypes));
      })
      .catch((error) => {
        const errorMessage = error.message;
        dispatch(fetchDrinkTypesFailure(errorMessage));
      });
  };
};