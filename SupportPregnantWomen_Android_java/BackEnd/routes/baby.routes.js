const express = require("express");

const babyController = require("../controllers/baby.controller");

const router = express.Router();

//1. Tạo baby
router.post("/babies", babyController.createBaby);

//2. lấy baby
router.post("/babies/get-baby", babyController.getBabyById);

//3. Sửa baby
router.post("/babies/update-baby", babyController.updateBaby);

module.exports = router;
