import Manage from "../Manage";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";
import { useSelector } from "react-redux";
import { useEffect, useState } from "react";

const ManageMenu = () => {
    const drinksFromRedux = useSelector(selectDrinks); // Subscribe to Redux state

    const [drinks, setDrinks] = useState([]);

    useEffect(() => {
        setDrinks(drinksFromRedux); // Update local state when Redux state changes
    }, [drinksFromRedux]);

    console.log(drinks);
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={drinks} type={"menu"}></Manage>;
};

export default ManageMenu;
