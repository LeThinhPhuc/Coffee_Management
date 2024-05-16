import React, { useEffect, useState } from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";
import Manage from "../Manage";

const ManageDrinkType = () => {
    const shopId = "097e25ff-94f7-4845-a2b9-9e873474e785";
    const drinkTypes = useSelector(selectTypes);
    console.log(drinkTypes);

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
