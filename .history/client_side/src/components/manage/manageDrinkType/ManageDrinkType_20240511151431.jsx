import React from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";

const ManageDrinkType = () => {
    const shopId = "e38c802f-3e35-4aa6-bd64-a4124aab7adb";
    const data = useSelector(selectTypes);
    console.log(data);
    return <div>Hello world</div>;
};

export default ManageDrinkType;
