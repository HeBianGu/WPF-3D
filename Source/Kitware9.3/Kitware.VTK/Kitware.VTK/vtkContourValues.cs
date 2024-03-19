using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourValues
	/// </summary>
	/// <remarks>
	///    helper object to manage setting and generating contour values
	///
	/// vtkContourValues is a general class to manage the creation, generation,
	/// and retrieval of contour values. This class serves as a helper class for
	/// contouring classes, or those classes operating on lists of contour values.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter
	/// </seealso>
	// Token: 0x02000AFE RID: 2814
	public class vtkContourValues : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D91B RID: 121115 RVA: 0x0029C3DD File Offset: 0x0029A5DD
		static vtkContourValues()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourValues.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourValues"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D91C RID: 121116 RVA: 0x0029C405 File Offset: 0x0029A605
		public vtkContourValues(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D91D RID: 121117
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourValues_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D91E RID: 121118 RVA: 0x0029C414 File Offset: 0x0029A614
		public new static vtkContourValues New()
		{
			vtkContourValues result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourValues.vtkContourValues_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D91F RID: 121119 RVA: 0x0029C468 File Offset: 0x0029A668
		public vtkContourValues() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContourValues.vtkContourValues_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D920 RID: 121120 RVA: 0x0029C4AC File Offset: 0x0029A6AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D921 RID: 121121
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourValues_DeepCopy_01(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy contours.
		/// </summary>
		// Token: 0x0601D922 RID: 121122 RVA: 0x0029C4B8 File Offset: 0x0029A6B8
		public void DeepCopy(vtkContourValues other)
		{
			vtkContourValues.vtkContourValues_DeepCopy_01(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		// Token: 0x0601D923 RID: 121123
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourValues_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0601D924 RID: 121124 RVA: 0x0029C4E7 File Offset: 0x0029A6E7
		public void GenerateValues(int numContours, IntPtr range)
		{
			vtkContourValues.vtkContourValues_GenerateValues_02(base.GetCppThis(), numContours, range);
		}

		// Token: 0x0601D925 RID: 121125
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourValues_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

		/// <summary>
		/// Generate numContours equally spaced contour values between specified
		/// range. Contour values will include min/max range values.
		/// </summary>
		// Token: 0x0601D926 RID: 121126 RVA: 0x0029C4F8 File Offset: 0x0029A6F8
		public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
		{
			vtkContourValues.vtkContourValues_GenerateValues_03(base.GetCppThis(), numContours, rangeStart, rangeEnd);
		}

		// Token: 0x0601D927 RID: 121127
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourValues_GetNumberOfContours_04(HandleRef pThis);

		/// <summary>
		/// Return the number of contours in the
		/// </summary>
		// Token: 0x0601D928 RID: 121128 RVA: 0x0029C50C File Offset: 0x0029A70C
		public int GetNumberOfContours()
		{
			return vtkContourValues.vtkContourValues_GetNumberOfContours_04(base.GetCppThis());
		}

		// Token: 0x0601D929 RID: 121129
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourValues_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D92A RID: 121130 RVA: 0x0029C52C File Offset: 0x0029A72C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourValues.vtkContourValues_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D92B RID: 121131
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourValues_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D92C RID: 121132 RVA: 0x0029C54C File Offset: 0x0029A74C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourValues.vtkContourValues_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601D92D RID: 121133
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContourValues_GetValue_07(HandleRef pThis, int i);

		/// <summary>
		/// Get the ith contour value. The return value will be clamped if the
		/// index i is out of range.
		/// </summary>
		// Token: 0x0601D92E RID: 121134 RVA: 0x0029C568 File Offset: 0x0029A768
		public double GetValue(int i)
		{
			return vtkContourValues.vtkContourValues_GetValue_07(base.GetCppThis(), i);
		}

		// Token: 0x0601D92F RID: 121135
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourValues_GetValues_08(HandleRef pThis);

		/// <summary>
		/// Return a pointer to a list of contour values. The contents of the
		/// list will be garbage if the number of contours &lt;= 0.
		/// </summary>
		// Token: 0x0601D930 RID: 121136 RVA: 0x0029C588 File Offset: 0x0029A788
		public IntPtr GetValues()
		{
			return vtkContourValues.vtkContourValues_GetValues_08(base.GetCppThis());
		}

		// Token: 0x0601D931 RID: 121137
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourValues_GetValues_09(HandleRef pThis, IntPtr contourValues);

		/// <summary>
		/// Fill a supplied list with contour values. Make sure you've
		/// allocated memory of size GetNumberOfContours().
		/// </summary>
		// Token: 0x0601D932 RID: 121138 RVA: 0x0029C5A7 File Offset: 0x0029A7A7
		public void GetValues(IntPtr contourValues)
		{
			vtkContourValues.vtkContourValues_GetValues_09(base.GetCppThis(), contourValues);
		}

		// Token: 0x0601D933 RID: 121139
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourValues_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D934 RID: 121140 RVA: 0x0029C5B8 File Offset: 0x0029A7B8
		public override int IsA(string type)
		{
			return vtkContourValues.vtkContourValues_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601D935 RID: 121141
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourValues_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D936 RID: 121142 RVA: 0x0029C5D8 File Offset: 0x0029A7D8
		public new static int IsTypeOf(string type)
		{
			return vtkContourValues.vtkContourValues_IsTypeOf_11(type);
		}

		// Token: 0x0601D937 RID: 121143
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourValues_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D938 RID: 121144 RVA: 0x0029C5F4 File Offset: 0x0029A7F4
		public new vtkContourValues NewInstance()
		{
			vtkContourValues result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourValues.vtkContourValues_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D939 RID: 121145
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourValues_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with a single contour value at 0.0.
		/// </summary>
		// Token: 0x0601D93A RID: 121146 RVA: 0x0029C650 File Offset: 0x0029A850
		public new static vtkContourValues SafeDownCast(vtkObjectBase o)
		{
			vtkContourValues vtkContourValues = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourValues.vtkContourValues_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourValues = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourValues.Register(null);
				}
			}
			return vtkContourValues;
		}

		// Token: 0x0601D93B RID: 121147
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourValues_SetNumberOfContours_15(HandleRef pThis, int number);

		/// <summary>
		/// Set the number of contours to place into the list. You only really
		/// need to use this method to reduce list size. The method SetValue()
		/// will automatically increase list size as needed.
		/// </summary>
		// Token: 0x0601D93C RID: 121148 RVA: 0x0029C6CF File Offset: 0x0029A8CF
		public void SetNumberOfContours(int number)
		{
			vtkContourValues.vtkContourValues_SetNumberOfContours_15(base.GetCppThis(), number);
		}

		// Token: 0x0601D93D RID: 121149
		[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourValues_SetValue_16(HandleRef pThis, int i, double value);

		/// <summary>
		/// Set the ith contour value.
		/// </summary>
		// Token: 0x0601D93E RID: 121150 RVA: 0x0029C6DF File Offset: 0x0029A8DF
		public void SetValue(int i, double value)
		{
			vtkContourValues.vtkContourValues_SetValue_16(base.GetCppThis(), i, value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F23 RID: 7971
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourValues";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F24 RID: 7972
		public new static readonly string MRClassNameKey = "class vtkContourValues";
	}
}
