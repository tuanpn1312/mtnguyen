module.exports = (sequelize, Sequelize) => {
  const Post = sequelize.define(
    "post",
    {
      user_id: {
        type: Sequelize.UUID,
        allowNull: false,
      },

      post_id: {
        type: Sequelize.UUID,
        allowNull: false,
        unique: true,
        primaryKey: true,
      },

      description: {
        type: Sequelize.STRING,
        allowNull: false,
      },

      ngay_tai_kham: {
        type: Sequelize.DATE,
        allowNull: false,
      },
    },
    {
      timestamps: false,
      tableName: "post",
    }
  );
  return Post;
};
