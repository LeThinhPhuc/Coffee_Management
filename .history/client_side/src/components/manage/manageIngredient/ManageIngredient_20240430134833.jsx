import React, { useEffect, useState } from "react";
import TemplateDataIngredient from "./TemplateDataIngredient";
import "../styles.css";
import Manage from "../Manage";
import { useSelector, useDispatch } from "react-redux";
import { selectIngredients } from "../../../redux/Reducer/ingredientSlice";
import { fetchIngredients } from "../../../redux/Action/ingredientAction";

const ManageIngredient = () => {
    //! Truyền data, type cho component Manage để sài chung
    const ingredients = useSelector(selectIngredients);
    // console.log("ManageIngredient");
    // console.log(ingredients);

    const [data, setData] = useState([]);

    useEffect(() => {
        setData([
            {
                category: "Nguyên liệu",
                items: [...ingredients],
            },
        ]);
    }, [ingredients]);

    return (
        <div>
            <Manage data={data} type={"ingredient"}></Manage>;{/* Hello */}
        </div>
    );
};

export default ManageIngredient;
