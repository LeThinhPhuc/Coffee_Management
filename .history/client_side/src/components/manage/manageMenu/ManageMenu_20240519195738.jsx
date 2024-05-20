import Manage from "../Manage";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";
import { useSelector } from "react-redux";
import { useEffect } from "react";

const ManageMenu = () => {
    const drinks = useSelector(selectDrinks);
    console.log(drinks);
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={drinks} type={"menu"}></Manage>;
};

export default ManageMenu;
