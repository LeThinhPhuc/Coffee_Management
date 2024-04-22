import { createSlice } from "@reduxjs/toolkit";
const initialState={
    vouchers:[],
    error:null
}

const voucherSlice = createSlice({
    name:'voucher',
    initialState,
    reducers:{
        addVoucherSuccess(state,action){
            state.vouchers.push(action.payload);
            console.log("order da co: ",state.vouchers)
            state.error=null;
        },
        fetchVoucherSuccess(state,action){
            state.vouchers=action.payload;
            state.error=null;
        }
    }
})


export const{
    addVoucherSuccess,
    fetchVoucherSuccess
}=voucherSlice.actions;
export const selectVouchers = state =>state.voucher.vouchers;
export default voucherSlice.reducer;