import React, { useState } from "react";
import TemplateDataMenu from "./TemplateDataMenu";
import Manage from "../Manage";

const ManageMenu = () => {
    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={TemplateDataMenu} type={"menu"}></Manage>;
};

export default ManageMenu;
