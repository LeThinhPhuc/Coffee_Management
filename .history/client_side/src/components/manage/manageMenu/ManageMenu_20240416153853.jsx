import React, { useEffect, useRef, useState } from "react";
import TemplateDataMenu from "./TemplateDataMenu";
import Manage from "../Manage";
import axios from "axios";
import "../styles.css";

const ManageMenu = () => {
    const [data, setData] = useState(null);
    const [isLoading, setIsLoading] = useState(false);
    const handleFetchData = useRef({});

    handleFetchData.current = async () => {
        //!
        setIsLoading(true);

        try {
            const response = await axios.get(
                "http://localhost:5146/api/Drink/getallgrouped"
            );
            // const data = await response.json();
            setData(response.data);
            console.log(data);
        } catch (error) {
            console.log("Error: " + error);
        } finally {
            // handle Loading
        }

        //!
        setIsLoading(false);
    };

    useEffect(() => {
        handleFetchData.current();
    }, []);

    //! Truyền data, type cho component Manage để sài chung
    return <Manage data={TemplateDataMenu} type={"menu"}></Manage>;
};

export default ManageMenu;
