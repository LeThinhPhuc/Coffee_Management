// Coffee_Management/client_side/src/redux/Reducer/voucherSlice.jsx
import { createSlice } from "@reduxjs/toolkit";

const initialState = {
  vouchers: [],
  error: null
};

const voucherSlice = createSlice({
  name: 'voucher',
  initialState,
  reducers: {
    addVoucherSuccess(state, action) {
      state.vouchers.push(action.payload);
      state.error = null;
    },
    fetchVoucherSuccess(state, action) {
      state.vouchers = action.payload;
      state.error = null;
    },
    updateVoucherSuccess(state, action) {
      const index = state.vouchers.findIndex(voucher => voucher.id === action.payload.id);
      if (index !== -1) {
        state.vouchers[index] = action.payload;
      }
      state.error = null;
    },
    deleteVoucherSuccess(state, action) {
      state.vouchers = state.vouchers.filter(voucher => voucher.id !== action.payload);
      state.error = null;
    },
    voucherFailure(state, action) {
      state.error = action.payload;
    }
  }
});

export const {
  addVoucherSuccess,
  fetchVoucherSuccess,
  updateVoucherSuccess,
  deleteVoucherSuccess,
  voucherFailure
} = voucherSlice.actions;

export const selectVouchers = state => state.voucher.vouchers;

export default voucherSlice.reducer;
