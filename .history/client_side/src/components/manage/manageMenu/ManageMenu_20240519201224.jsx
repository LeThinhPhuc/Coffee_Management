import Manage from "../Manage";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";
import { selectTypes } from "../../../redux/Reducer/typeSlice";
import { useSelector } from "react-redux";
import { useEffect, useState } from "react";

const ManageMenu = () => {
    const drinksFromRedux = useSelector(selectDrinks); // Subscribe to Redux state
    const drinkTypes = useSelector(selectTypes); // Subscribe to Redux state

    const [drinks, setDrinks] = useState([]);

    useEffect(() => {
        // Map drinks to their corresponding categories (DrinkType)
        const updatedDrinks = drinkTypes.map((type) => {
            return {
                category: type.name,
                items: drinksFromRedux.filter(
                    (drink) => drink.drinkTypeId === type.id
                ),
            };
        });

        setDrinks(updatedDrinks); // Update local state when Redux state changes
    }, [drinksFromRedux, drinkTypes]);

    console.log(drinks);

    return <Manage data={drinks} type={"menu"} />;
};

export default ManageMenu;
