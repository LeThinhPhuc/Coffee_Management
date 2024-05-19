import React, { useEffect, useState } from "react";
import { useSelector } from "react-redux";
import { selectTypes } from "../../../redux/Reducer/typeSlice";
import Manage from "../Manage";

// TkMinh's code
const ManageDrinkType = () => {
    const { shops } = JSON.parse(localStorage.getItem("user"));
    const shopId = shops[0].id;
    const drinkTypes = useSelector(selectTypes);

    const [data, setData] = useState([]);

    useEffect(() => {
        console.log("shop id:", shopId); // Add this line for debugging
        console.log("drinkTypes:", drinkTypes); // Add this line for debugging

        setData([
            {
                category: "Category",
                items: Array.isArray(drinkTypes) ? [...drinkTypes] : [], // Add a check here
            },
        ]);
    }, [drinkTypes]);

    return <Manage data={data} shopId={shopId} type="drinkType"></Manage>;
};

// Fix Minh's error: TypeError: Spread syntax requires ...iterable[Symbol.iterator] to be a function
//*
// const ManageDrinkType = () => {
//     const shopId = "e38c802f-3e35-4aa6-bd64-a4124aab7adb";  // harcode !!!!
//     console.log('shop id:', shopId);
//     const drinkTypes = useSelector(selectTypes);

//     const [data, setData] = useState([]);
//     useEffect(() => {
//         console.log('drinkTypes:', drinkTypes);  // Add this line
//         setData([
//             {
//                 category: "Category",
//                 items: Array.isArray(drinkTypes) ? [...drinkTypes] : [],  // Add a check here
//             },
//         ]);
//     }, [drinkTypes]);

//     return <Manage data={data} shopId={shopId} type="drinkType"></Manage>;
// };
//*/

export default ManageDrinkType;
