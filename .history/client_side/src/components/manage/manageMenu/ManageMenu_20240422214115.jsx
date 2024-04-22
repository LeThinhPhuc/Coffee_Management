import Manage from "../Manage";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";
import { useSelector } from "react-redux";
import { selectIngredients } from "../../../redux/Reducer/ingredientSlice";

const ManageMenu = () => {
    const drinks = useSelector(selectDrinks);
    const ingredients = useSelector(selectIngredients);
    console.log("ne ne");
    console.log(ingredients);
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={drinks} type={"menu"}></Manage>;
};

export default ManageMenu;
