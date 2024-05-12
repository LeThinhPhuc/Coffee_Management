import React, { useEffect, useState } from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";
import Manage from "../Manage";

const ManageDrinkType = () => {
    const shopId = "e38c802f-3e35-4aa6-bd64-a4124aab7adb";
    const drinkTypes = useSelector(selectTypes);

    const [data, setData] = useState([]);
    useEffect(() => {
        setData([
            {
                category: "Danh mục trong Menu",
                items: [...drinkTypes],
            },
        ]);
    }, [drinkTypes]);

    return <Manage data={data} shopId={shopId} type="drinkType"></Manage>;
};

export default ManageDrinkType;
