import React, { useState } from "react";
import TemplateDataMenu from "./TemplateDataMenu";
import Manage from "../Manage";

const ManageMenu = () => {
    return <Manage data={TemplateDataMenu} type={"menu"}></Manage>;
};

export default ManageMenu;
