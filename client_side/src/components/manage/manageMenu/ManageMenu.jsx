import Manage from "../Manage";
import "../styles.css";
import { selectDrinks } from "../../../redux/Reducer/drinkSlice";
import { useSelector } from "react-redux";

const ManageMenu = () => {
  const drinks = useSelector(selectDrinks);
  //! Truyền data, type cho component Manage để sài chung
  return <Manage data={drinks} type={"menu"}></Manage>;
};

export default ManageMenu;
