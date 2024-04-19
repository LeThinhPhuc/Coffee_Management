import { useEffect, useRef, useState } from "react";
import Manage from "../Manage";
import axios from "axios";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";

const ManageMenu = () => {
    const drinks = selectDrinks();
    console.log(drinks);
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={drinks} type={"menu"}></Manage>;
};

export default ManageMenu;
