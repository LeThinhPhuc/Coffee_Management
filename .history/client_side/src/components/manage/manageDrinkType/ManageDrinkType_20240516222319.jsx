import React, { useEffect, useState } from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";
import Manage from "../Manage";

const ManageDrinkType = () => {
    const { shops } = JSON.parse(localStorage.getItem("user"));
    const shopId = shops[0].id;
    const drinkTypes = useSelector(selectTypes);

    const [data, setData] = useState([]);
    useEffect(() => {
        setData([
            {
                category: "Category",
                items: [...drinkTypes],
            },
        ]);
    }, [drinkTypes]);

    return <Manage data={data} shopId={shopId} type="drinkType"></Manage>;
};

export default ManageDrinkType;
