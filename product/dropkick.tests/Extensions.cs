using Magnum;

namespace dropkick.tests
{
    using NUnit.Framework;

    public static class Extensions
    {
        public static void ShouldBeTrue(this bool actual)
        {
            Assert.IsTrue(actual);
        }
        public static void ShouldBeFalse(this bool actual)
        {
            Assert.IsTrue(actual);
        }
        public static void ShouldBeEqualTo(this object actual,object expected)
        {
            Assert.AreEqual(expected,actual);
        }

        public static void ShouldBeOfType<T>(this object actual)
        {
            Assert.AreEqual(typeof(T), actual.GetType());
        }

		public static void ShouldNotBeNull(this object actual)
		{
			Assert.IsNotNull(actual);
		}

		public static void ShouldContain<T>(this System.Collections.Generic.ICollection<T> collection, T item)
		{
			Guard.AgainstNull(collection, "Collection is null, cannot assert item membership.");
			Assert.IsTrue(collection.Contains(item), 
				"Collection of type '{0}' does not contain expected item '{1}'", 
				typeof(T).Name, 
				item == null ? "(null)" : item.ToString());
		}
    }
}