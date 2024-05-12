import React from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";
import Manage from "../Manage";

const ManageDrinkType = () => {
    const shopId = "e38c802f-3e35-4aa6-bd64-a4124aab7adb";
    const data = useSelector(selectTypes);
    console.log(data);
    return <Manage shopId={shopId}></Manage>;
};

export default ManageDrinkType;
