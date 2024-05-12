import React from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";

const ManageDrinkType = () => {
    const data = useSelector(selectTypes);
    console.log(data);
    return <div>Hello world</div>;
};

export default ManageDrinkType;
