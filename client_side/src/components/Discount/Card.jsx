const Card = () => {
  return (
    <>
      <div className="container mx-auto">
        <div className="bg-gradient-to-br from-white bg-opacity-30 backdrop-blur-sm to-wood text-white text-center py-2 px-2 rounded-lg shadow-md relative">
          <h3 className="text-2xl font-semibold mb-4">
            20% flat off on all rides within the city
            <br />
            using HDFC Credit Card
          </h3>
          <div className="flex items-center space-x-2 mb-6">
            <span
              id="cpnCode"
              className="border-dashed border text-white px-4 py-2 rounded-l"
            >
              STEALDEAL20
            </span>
            <span
              id="cpnBtn"
              className="border border-white bg-white text-purple-600 px-4 py-2 rounded-r cursor-pointer"
            >
              Copy Code
            </span>
          </div>
          <p className="text-sm">Valid Till: 20Dec, 2021</p>

          <div className="w-12 h-12 bg-white rounded-full absolute top-1/2 transform -translate-y-1/2 left-0 -ml-6"></div>
          <div className="w-12 h-12 bg-white rounded-full absolute top-1/2 transform -translate-y-1/2 right-0 -mr-6"></div>
        </div>
      </div>
    </>
  );
};

export default Card;
