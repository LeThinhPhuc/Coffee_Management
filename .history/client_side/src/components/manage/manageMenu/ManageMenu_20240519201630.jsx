import Manage from "../Manage";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";
import { useSelector } from "react-redux";
import { useEffect, useState } from "react";
import { selectTypes } from "../../../redux/Reducer/typeSlice";

const ManageMenu = () => {
    const drinksFromRedux = useSelector(selectDrinks); // Subscribe to Redux state
    const drinkType = useSelector(selectTypes); // Subscribe to Redux state
    // console.log(drinkType);

    const [drinks, setDrinks] = useState([]);

    useEffect(() => {
        setDrinks(drinksFromRedux); // Update local state when Redux state changes
    }, [drinksFromRedux]);

    console.log("Drinks ne");
    console.log(drinks);
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={drinks} type={"menu"}></Manage>;
};

export default ManageMenu;
