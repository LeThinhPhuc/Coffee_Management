import { useEffect, useRef, useState } from "react";
import Manage from "../Manage";
import axios from "axios";
import "../styles.css";

const ManageMenu = () => {
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={data} type={"menu"}></Manage>;
};

export default ManageMenu;
