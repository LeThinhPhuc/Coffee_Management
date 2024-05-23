// Coffee_Management/client_side/src/redux/Action/voucherAction.jsx
import VoucherService from "../../services/VoucherService";
import {
  fetchVoucherSuccess,
  addVoucherSuccess,
  updateVoucherSuccess,
  deleteVoucherSuccess,
  voucherFailure,
} from "../Reducer/voucherSlice";
import { toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";

export const fetchVouchers = () => {
  return async (dispatch) => {
    try {
      const response = await VoucherService.getAll();
      dispatch(fetchVoucherSuccess(response.data));
    } catch (error) {
      dispatch(voucherFailure(error.message));
    }
  };
};

export const addVoucher = (data) => {
  return async (dispatch) => {
    try {
      const response = await VoucherService.addVoucherCode(data);
      if (response.data.succeeded) {
        dispatch(addVoucherSuccess(response.data));
        toast.success(response.data.message, {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      } else {
        toast.error(response.data.message, {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      }
    } catch (error) {
      dispatch(voucherFailure(error.message));
      if (error.response && error.response.data && error.response.data.errors) {
        error.response.data.errors.forEach((err) => {
          toast.error(err.description, {
            position: "top-left",
            autoClose: 5000,
            hideProgressBar: false,
            closeOnClick: true,
            pauseOnHover: true,
            draggable: true,
            progress: undefined,
          });
        });
      } else {
        toast.error("An error occurred while logging in. Please try again.", {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      }
    }
    // try {
    //   const response = await VoucherService.addVoucherCode(data);
    //   dispatch(addVoucherSuccess(response.data));
    // } catch (error) {
    //   dispatch(voucherFailure(error.message));
    // }
  };
};

export const updateVoucher = (data) => {
  return async (dispatch) => {
    try {
      const response = await VoucherService.updateVoucherCode(data);
      if (response.data.succeeded) {
        dispatch(updateVoucherSuccess(response.data));
        toast.success(response.data.message, {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      } else {
        toast.error(response.data.message, {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      }
    } catch (error) {
      dispatch(voucherFailure(error.message));
    }
  };
};

export const deleteVoucher = (id) => {
  return async (dispatch) => {
    try {
      const response = await VoucherService.deleteVoucherCode(id);
      if (response.data.succeeded) {
        dispatch(deleteVoucherSuccess(id));
        toast.success(response.data.message, {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      } else {
        toast.error(response.data.message, {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      }
    } catch (error) {
      dispatch(voucherFailure(error.message));
      if (error.response && error.response.data && error.response.data.errors) {
        error.response.data.errors.forEach((err) => {
          toast.error(err.description, {
            position: "top-left",
            autoClose: 5000,
            hideProgressBar: false,
            closeOnClick: true,
            pauseOnHover: true,
            draggable: true,
            progress: undefined,
          });
        });
      } else {
        toast.error("An error occurred while logging in. Please try again.", {
          position: "top-left",
          autoClose: 5000,
          hideProgressBar: false,
          closeOnClick: true,
          pauseOnHover: true,
          draggable: true,
          progress: undefined,
        });
      }
    }
    // try {
    //   await VoucherService.deleteVoucherCode(id);
    //   dispatch(deleteVoucherSuccess(id));
    // } catch (error) {
    //   dispatch(voucherFailure(error.message));
    // }
  };
};
