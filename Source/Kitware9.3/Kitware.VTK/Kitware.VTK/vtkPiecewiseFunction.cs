using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPiecewiseFunction
	/// </summary>
	/// <remarks>
	///    Defines a 1D piecewise function.
	///
	///
	/// Defines a piecewise function mapping. This mapping allows the addition
	/// of control points, and allows the user to control the function between
	/// the control points. A piecewise hermite curve is used between control
	/// points, based on the sharpness and midpoint parameters. A sharpness of
	/// 0 yields a piecewise linear function and a sharpness of 1 yields a
	/// piecewise constant function. The midpoint is the normalized distance
	/// between control points at which the curve reaches the median Y value.
	/// The midpoint and sharpness values specified when adding a node are used
	/// to control the transition to the next node (the last node's values are
	/// ignored) Outside the range of nodes, the values are 0 if Clamping is off,
	/// or the nearest node point if Clamping is on. Using the legacy methods for
	/// adding points  (which do not have Sharpness and Midpoint parameters)
	/// will default to Midpoint = 0.5 (halfway between the control points) and
	/// Sharpness = 0.0 (linear).
	/// </remarks>
	// Token: 0x02000A93 RID: 2707
	public class vtkPiecewiseFunction : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C60A RID: 116234 RVA: 0x0027DE13 File Offset: 0x0027C013
		static vtkPiecewiseFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPiecewiseFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C60B RID: 116235 RVA: 0x0027DE3B File Offset: 0x0027C03B
		public vtkPiecewiseFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C60C RID: 116236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C60D RID: 116237 RVA: 0x0027DE4C File Offset: 0x0027C04C
		public new static vtkPiecewiseFunction New()
		{
			vtkPiecewiseFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C60E RID: 116238 RVA: 0x0027DEA0 File Offset: 0x0027C0A0
		public vtkPiecewiseFunction() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPiecewiseFunction.vtkPiecewiseFunction_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C60F RID: 116239 RVA: 0x0027DEE4 File Offset: 0x0027C0E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C610 RID: 116240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_AddPoint_01(HandleRef pThis, double x, double y);

		/// <summary>
		/// Add points to the function. If a duplicate point is added
		/// then the previous point is removed unless
		/// AllowDuplicateScalars is set to true
		/// Return the index of the point (0 based), or -1 on error.
		/// </summary>
		// Token: 0x0601C611 RID: 116241 RVA: 0x0027DEF0 File Offset: 0x0027C0F0
		public int AddPoint(double x, double y)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_AddPoint_01(base.GetCppThis(), x, y);
		}

		// Token: 0x0601C612 RID: 116242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_AddPoint_02(HandleRef pThis, double x, double y, double midpoint, double sharpness);

		/// <summary>
		/// Add points to the function. If a duplicate point is added
		/// then the previous point is removed unless
		/// AllowDuplicateScalars is set to true
		/// Return the index of the point (0 based), or -1 on error.
		/// </summary>
		// Token: 0x0601C613 RID: 116243 RVA: 0x0027DF14 File Offset: 0x0027C114
		public int AddPoint(double x, double y, double midpoint, double sharpness)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_AddPoint_02(base.GetCppThis(), x, y, midpoint, sharpness);
		}

		// Token: 0x0601C614 RID: 116244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_AddSegment_03(HandleRef pThis, double x1, double y1, double x2, double y2);

		/// <summary>
		/// Add a line segment to the function. All points defined between the
		/// two points specified are removed from the function.
		/// To specify the sharpness and midpoint values, use AddPoint method instead.
		/// </summary>
		// Token: 0x0601C615 RID: 116245 RVA: 0x0027DF38 File Offset: 0x0027C138
		public void AddSegment(double x1, double y1, double x2, double y2)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_AddSegment_03(base.GetCppThis(), x1, y1, x2, y2);
		}

		// Token: 0x0601C616 RID: 116246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_AdjustRange_04(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Remove all points out of the new range, and make sure there is a point
		/// at each end of that range.
		/// Return 1 on success, 0 otherwise.
		/// </summary>
		// Token: 0x0601C617 RID: 116247 RVA: 0x0027DF4C File Offset: 0x0027C14C
		public int AdjustRange(IntPtr range)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_AdjustRange_04(base.GetCppThis(), range);
		}

		// Token: 0x0601C618 RID: 116248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_AllowDuplicateScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the piecewise
		/// function (off by default).
		/// </summary>
		// Token: 0x0601C619 RID: 116249 RVA: 0x0027DF6C File Offset: 0x0027C16C
		public virtual void AllowDuplicateScalarsOff()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_AllowDuplicateScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x0601C61A RID: 116250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_AllowDuplicateScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the piecewise
		/// function (off by default).
		/// </summary>
		// Token: 0x0601C61B RID: 116251 RVA: 0x0027DF7B File Offset: 0x0027C17B
		public virtual void AllowDuplicateScalarsOn()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_AllowDuplicateScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x0601C61C RID: 116252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_BuildFunctionFromTable_07(HandleRef pThis, double x1, double x2, int size, IntPtr table, int stride);

		/// <summary>
		/// Constructs a piecewise function from a table.  Function range is
		/// is set to [x1, x2], function size is set to size, and function points
		/// are regularly spaced between x1 and x2.  Parameter "stride" is
		/// is step through the input table.
		/// </summary>
		// Token: 0x0601C61D RID: 116253 RVA: 0x0027DF8A File Offset: 0x0027C18A
		public void BuildFunctionFromTable(double x1, double x2, int size, IntPtr table, int stride)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_BuildFunctionFromTable_07(base.GetCppThis(), x1, x2, size, table, stride);
		}

		// Token: 0x0601C61E RID: 116254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_ClampingOff_08(HandleRef pThis);

		/// <summary>
		/// When zero range clamping is Off, GetValue() returns 0.0 when a
		/// value is requested outside of the points specified.
		/// When zero range clamping is On, GetValue() returns the value at
		/// the value at the lowest point for a request below all points
		/// specified and returns the value at the highest point for a request
		/// above all points specified. On is the default.
		/// </summary>
		// Token: 0x0601C61F RID: 116255 RVA: 0x0027DFA0 File Offset: 0x0027C1A0
		public virtual void ClampingOff()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_ClampingOff_08(base.GetCppThis());
		}

		// Token: 0x0601C620 RID: 116256
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_ClampingOn_09(HandleRef pThis);

		/// <summary>
		/// When zero range clamping is Off, GetValue() returns 0.0 when a
		/// value is requested outside of the points specified.
		/// When zero range clamping is On, GetValue() returns the value at
		/// the value at the lowest point for a request below all points
		/// specified and returns the value at the highest point for a request
		/// above all points specified. On is the default.
		/// </summary>
		// Token: 0x0601C621 RID: 116257 RVA: 0x0027DFAF File Offset: 0x0027C1AF
		public virtual void ClampingOn()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_ClampingOn_09(base.GetCppThis());
		}

		// Token: 0x0601C622 RID: 116258
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_DeepCopy_10(HandleRef pThis, HandleRef f);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C623 RID: 116259 RVA: 0x0027DFC0 File Offset: 0x0027C1C0
		public override void DeepCopy(vtkDataObject f)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_DeepCopy_10(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x0601C624 RID: 116260
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_EstimateMinNumberOfSamples_11(HandleRef pThis, ref double x1, ref double x2);

		/// <summary>
		/// Estimates the minimum size of a table such that it would correctly sample this function.
		/// The returned value should be passed as parameter 'n' when calling GetTable().
		/// </summary>
		// Token: 0x0601C625 RID: 116261 RVA: 0x0027DFF0 File Offset: 0x0027C1F0
		public int EstimateMinNumberOfSamples(ref double x1, ref double x2)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_EstimateMinNumberOfSamples_11(base.GetCppThis(), ref x1, ref x2);
		}

		// Token: 0x0601C626 RID: 116262
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_FillFromDataPointer_12(HandleRef pThis, int arg0, IntPtr arg1);

		/// <summary>
		/// Returns a pointer to the data stored in the table.
		/// Fills from a pointer to data stored in a similar table. These are
		/// legacy methods which will be maintained for compatibility - however,
		/// note that the vtkPiecewiseFunction no longer stores the nodes
		/// in a double array internally.
		/// </summary>
		// Token: 0x0601C627 RID: 116263 RVA: 0x0027E011 File Offset: 0x0027C211
		public void FillFromDataPointer(int arg0, IntPtr arg1)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_FillFromDataPointer_12(base.GetCppThis(), arg0, arg1);
		}

		// Token: 0x0601C628 RID: 116264
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetAllowDuplicateScalars_13(HandleRef pThis);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the piecewise
		/// function (off by default).
		/// </summary>
		// Token: 0x0601C629 RID: 116265 RVA: 0x0027E024 File Offset: 0x0027C224
		public virtual int GetAllowDuplicateScalars()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetAllowDuplicateScalars_13(base.GetCppThis());
		}

		// Token: 0x0601C62A RID: 116266
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetAutomaticSearchMethod_14(HandleRef pThis);

		/// <summary>
		/// Methods to set / get the search method used.
		/// By default the search method used is the one automatically updated
		/// each time the data is modified.
		/// This behavior can be overridden by using SetUseCustomSearchMethod() and SetCustomSearchMethod()
		/// </summary>
		// Token: 0x0601C62B RID: 116267 RVA: 0x0027E044 File Offset: 0x0027C244
		public int GetAutomaticSearchMethod()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetAutomaticSearchMethod_14(base.GetCppThis());
		}

		// Token: 0x0601C62C RID: 116268
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetClamping_15(HandleRef pThis);

		/// <summary>
		/// When zero range clamping is Off, GetValue() returns 0.0 when a
		/// value is requested outside of the points specified.
		/// When zero range clamping is On, GetValue() returns the value at
		/// the value at the lowest point for a request below all points
		/// specified and returns the value at the highest point for a request
		/// above all points specified. On is the default.
		/// </summary>
		// Token: 0x0601C62D RID: 116269 RVA: 0x0027E064 File Offset: 0x0027C264
		public virtual int GetClamping()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetClamping_15(base.GetCppThis());
		}

		// Token: 0x0601C62E RID: 116270
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetCustomSearchMethod_16(HandleRef pThis);

		/// <summary>
		/// Methods to set / get the search method used.
		/// By default the search method used is the one automatically updated
		/// each time the data is modified.
		/// This behavior can be overridden by using SetUseCustomSearchMethod() and SetCustomSearchMethod()
		/// </summary>
		// Token: 0x0601C62F RID: 116271 RVA: 0x0027E084 File Offset: 0x0027C284
		public int GetCustomSearchMethod()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetCustomSearchMethod_16(base.GetCppThis());
		}

		// Token: 0x0601C630 RID: 116272
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_GetData_17(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C631 RID: 116273 RVA: 0x0027E0A4 File Offset: 0x0027C2A4
		public new static vtkPiecewiseFunction GetData(vtkInformation info)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_GetData_17((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x0601C632 RID: 116274
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_GetData_18(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601C633 RID: 116275 RVA: 0x0027E124 File Offset: 0x0027C324
		public new static vtkPiecewiseFunction GetData(vtkInformationVector v, int i)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_GetData_18((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x0601C634 RID: 116276
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetDataObjectType_19(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601C635 RID: 116277 RVA: 0x0027E1A4 File Offset: 0x0027C3A4
		public override int GetDataObjectType()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetDataObjectType_19(base.GetCppThis());
		}

		// Token: 0x0601C636 RID: 116278
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_GetDataPointer_20(HandleRef pThis);

		/// <summary>
		/// Returns a pointer to the data stored in the table.
		/// Fills from a pointer to data stored in a similar table. These are
		/// legacy methods which will be maintained for compatibility - however,
		/// note that the vtkPiecewiseFunction no longer stores the nodes
		/// in a double array internally.
		/// </summary>
		// Token: 0x0601C637 RID: 116279 RVA: 0x0027E1C4 File Offset: 0x0027C3C4
		public IntPtr GetDataPointer()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetDataPointer_20(base.GetCppThis());
		}

		// Token: 0x0601C638 RID: 116280
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPiecewiseFunction_GetFirstNonZeroValue_21(HandleRef pThis);

		/// <summary>
		/// Returns the first point location which precedes a non-zero segment of the
		/// function. Note that the value at this point may be zero.
		/// </summary>
		// Token: 0x0601C639 RID: 116281 RVA: 0x0027E1E4 File Offset: 0x0027C3E4
		public double GetFirstNonZeroValue()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetFirstNonZeroValue_21(base.GetCppThis());
		}

		// Token: 0x0601C63A RID: 116282
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetNodeValue_22(HandleRef pThis, int index, IntPtr val);

		/// <summary>
		/// For the node specified by index, set/get the
		/// location (X), value (Y), midpoint, and sharpness
		/// values at the node. Returns -1 if the index is
		/// out of range, returns 1 otherwise.
		/// </summary>
		// Token: 0x0601C63B RID: 116283 RVA: 0x0027E204 File Offset: 0x0027C404
		public int GetNodeValue(int index, IntPtr val)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetNodeValue_22(base.GetCppThis(), index, val);
		}

		// Token: 0x0601C63C RID: 116284
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunction_GetNumberOfGenerationsFromBase_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C63D RID: 116285 RVA: 0x0027E228 File Offset: 0x0027C428
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetNumberOfGenerationsFromBase_23(base.GetCppThis(), type);
		}

		// Token: 0x0601C63E RID: 116286
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPiecewiseFunction_GetNumberOfGenerationsFromBaseType_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C63F RID: 116287 RVA: 0x0027E248 File Offset: 0x0027C448
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetNumberOfGenerationsFromBaseType_24(type);
		}

		// Token: 0x0601C640 RID: 116288
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_GetRange_25(HandleRef pThis);

		/// <summary>
		/// Returns the min and max node locations of the function.
		/// </summary>
		// Token: 0x0601C641 RID: 116289 RVA: 0x0027E264 File Offset: 0x0027C464
		public virtual double[] GetRange()
		{
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_GetRange_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601C642 RID: 116290
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_GetRange_26(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Returns the min and max node locations of the function.
		/// </summary>
		// Token: 0x0601C643 RID: 116291 RVA: 0x0027E2AC File Offset: 0x0027C4AC
		public virtual void GetRange(ref double _arg1, ref double _arg2)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_GetRange_26(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0601C644 RID: 116292
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_GetRange_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Returns the min and max node locations of the function.
		/// </summary>
		// Token: 0x0601C645 RID: 116293 RVA: 0x0027E2BD File Offset: 0x0027C4BD
		public virtual void GetRange(IntPtr _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_GetRange_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C646 RID: 116294
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_GetSize_28(HandleRef pThis);

		/// <summary>
		/// Get the number of points used to specify the function
		/// </summary>
		// Token: 0x0601C647 RID: 116295 RVA: 0x0027E2D0 File Offset: 0x0027C4D0
		public int GetSize()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetSize_28(base.GetCppThis());
		}

		// Token: 0x0601C648 RID: 116296
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_GetTable_29(HandleRef pThis, double x1, double x2, int size, IntPtr table, int stride, int logIncrements, double epsilon);

		/// <summary>
		/// Fills in an array of function values evaluated at regular intervals.
		/// Parameter "stride" is used to step through the output "table". If
		/// logIncrements is true, the intervals between entries will be constant in
		/// logarithmic space. epsilon is used to move midpoint away from extreme ends
		/// of range, it should be changed if the values are the same magnitude of
		/// the default epsilon.
		/// </summary>
		// Token: 0x0601C649 RID: 116297 RVA: 0x0027E2EF File Offset: 0x0027C4EF
		public void GetTable(double x1, double x2, int size, IntPtr table, int stride, int logIncrements, double epsilon)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_GetTable_29(base.GetCppThis(), x1, x2, size, table, stride, logIncrements, epsilon);
		}

		// Token: 0x0601C64A RID: 116298
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_GetType_30(HandleRef pThis);

		/// <summary>
		/// Return the type of function:
		/// Function Types:
		/// 0 : Constant        (No change in slope between end points)
		/// 1 : NonDecreasing   (Always increasing or zero slope)
		/// 2 : NonIncreasing   (Always decreasing or zero slope)
		/// 3 : Varied          (Contains both decreasing and increasing slopes)
		/// </summary>
		// Token: 0x0601C64B RID: 116299 RVA: 0x0027E30C File Offset: 0x0027C50C
		public string GetTypeWrapper()
		{
			string s = Marshal.PtrToStringAnsi(vtkPiecewiseFunction.vtkPiecewiseFunction_GetType_30(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601C64C RID: 116300
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPiecewiseFunction_GetUseLogScale_31(HandleRef pThis);

		/// <summary>
		/// Interpolate between the control points in base-10 logrithmic space.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0601C64D RID: 116301 RVA: 0x0027E348 File Offset: 0x0027C548
		public virtual bool GetUseLogScale()
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetUseLogScale_31(base.GetCppThis()) != 0;
		}

		// Token: 0x0601C64E RID: 116302
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkPiecewiseFunction_GetValue_32(HandleRef pThis, double x);

		/// <summary>
		/// Returns the value of the function at the specified location using
		/// the specified interpolation.
		/// </summary>
		// Token: 0x0601C64F RID: 116303 RVA: 0x0027E370 File Offset: 0x0027C570
		public double GetValue(double x)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_GetValue_32(base.GetCppThis(), x);
		}

		// Token: 0x0601C650 RID: 116304
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_Initialize_33(HandleRef pThis);

		/// <summary>
		/// Clears out the current function. A newly created vtkPiecewiseFunction
		/// is already initialized, so there is no need to call this method which
		/// in turn simply calls RemoveAllPoints()
		/// </summary>
		// Token: 0x0601C651 RID: 116305 RVA: 0x0027E390 File Offset: 0x0027C590
		public override void Initialize()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_Initialize_33(base.GetCppThis());
		}

		// Token: 0x0601C652 RID: 116306
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_IsA_34(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C653 RID: 116307 RVA: 0x0027E3A0 File Offset: 0x0027C5A0
		public override int IsA(string type)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_IsA_34(base.GetCppThis(), type);
		}

		// Token: 0x0601C654 RID: 116308
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_IsTypeOf_35([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C655 RID: 116309 RVA: 0x0027E3C0 File Offset: 0x0027C5C0
		public new static int IsTypeOf(string type)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_IsTypeOf_35(type);
		}

		// Token: 0x0601C656 RID: 116310
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C657 RID: 116311 RVA: 0x0027E3DC File Offset: 0x0027C5DC
		public new vtkPiecewiseFunction NewInstance()
		{
			vtkPiecewiseFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_NewInstance_37(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C658 RID: 116312
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_RemoveAllPoints_38(HandleRef pThis);

		/// <summary>
		/// Removes all points from the function.
		/// </summary>
		// Token: 0x0601C659 RID: 116313 RVA: 0x0027E436 File Offset: 0x0027C636
		public void RemoveAllPoints()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_RemoveAllPoints_38(base.GetCppThis());
		}

		// Token: 0x0601C65A RID: 116314
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_RemovePoint_39(HandleRef pThis, double x);

		/// <summary>
		/// Remove the first point found at the given x location
		/// Return the index of the remove point if any, -1 otherwise
		/// </summary>
		// Token: 0x0601C65B RID: 116315 RVA: 0x0027E448 File Offset: 0x0027C648
		public int RemovePoint(double x)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_RemovePoint_39(base.GetCppThis(), x);
		}

		// Token: 0x0601C65C RID: 116316
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_RemovePoint_40(HandleRef pThis, double x, double y);

		/// <summary>
		/// Remove the first point found at the given x and y location
		/// Return the index of the remove point if any, -1 otherwise
		/// </summary>
		// Token: 0x0601C65D RID: 116317 RVA: 0x0027E468 File Offset: 0x0027C668
		public int RemovePoint(double x, double y)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_RemovePoint_40(base.GetCppThis(), x, y);
		}

		// Token: 0x0601C65E RID: 116318
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPiecewiseFunction_RemovePointByIndex_41(HandleRef pThis, ulong id);

		/// <summary>
		/// Remove a point from the function at a given id
		/// Return true if point has been found and removed, false other wise
		/// </summary>
		// Token: 0x0601C65F RID: 116319 RVA: 0x0027E48C File Offset: 0x0027C68C
		public bool RemovePointByIndex(ulong id)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_RemovePointByIndex_41(base.GetCppThis(), id) != 0;
		}

		// Token: 0x0601C660 RID: 116320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPiecewiseFunction_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C661 RID: 116321 RVA: 0x0027E4B4 File Offset: 0x0027C6B4
		public new static vtkPiecewiseFunction SafeDownCast(vtkObjectBase o)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPiecewiseFunction.vtkPiecewiseFunction_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		// Token: 0x0601C662 RID: 116322
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_SetAllowDuplicateScalars_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Toggle whether to allow duplicate scalar values in the piecewise
		/// function (off by default).
		/// </summary>
		// Token: 0x0601C663 RID: 116323 RVA: 0x0027E533 File Offset: 0x0027C733
		public virtual void SetAllowDuplicateScalars(int _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetAllowDuplicateScalars_43(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C664 RID: 116324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_SetClamping_44(HandleRef pThis, int _arg);

		/// <summary>
		/// When zero range clamping is Off, GetValue() returns 0.0 when a
		/// value is requested outside of the points specified.
		/// When zero range clamping is On, GetValue() returns the value at
		/// the value at the lowest point for a request below all points
		/// specified and returns the value at the highest point for a request
		/// above all points specified. On is the default.
		/// </summary>
		// Token: 0x0601C665 RID: 116325 RVA: 0x0027E543 File Offset: 0x0027C743
		public virtual void SetClamping(int _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetClamping_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C666 RID: 116326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_SetCustomSearchMethod_45(HandleRef pThis, int type);

		/// <summary>
		/// Methods to set / get the search method used.
		/// By default the search method used is the one automatically updated
		/// each time the data is modified.
		/// This behavior can be overridden by using SetUseCustomSearchMethod() and SetCustomSearchMethod()
		/// </summary>
		// Token: 0x0601C667 RID: 116327 RVA: 0x0027E553 File Offset: 0x0027C753
		public void SetCustomSearchMethod(int type)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetCustomSearchMethod_45(base.GetCppThis(), type);
		}

		// Token: 0x0601C668 RID: 116328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPiecewiseFunction_SetNodeValue_46(HandleRef pThis, int index, IntPtr val);

		/// <summary>
		/// For the node specified by index, set/get the
		/// location (X), value (Y), midpoint, and sharpness
		/// values at the node. Returns -1 if the index is
		/// out of range, returns 1 otherwise.
		/// </summary>
		// Token: 0x0601C669 RID: 116329 RVA: 0x0027E564 File Offset: 0x0027C764
		public int SetNodeValue(int index, IntPtr val)
		{
			return vtkPiecewiseFunction.vtkPiecewiseFunction_SetNodeValue_46(base.GetCppThis(), index, val);
		}

		// Token: 0x0601C66A RID: 116330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_SetUseCustomSearchMethod_47(HandleRef pThis, byte use);

		/// <summary>
		/// Methods to set / get the search method used.
		/// By default the search method used is the one automatically updated
		/// each time the data is modified.
		/// This behavior can be overridden by using SetUseCustomSearchMethod() and SetCustomSearchMethod()
		/// </summary>
		// Token: 0x0601C66B RID: 116331 RVA: 0x0027E585 File Offset: 0x0027C785
		public void SetUseCustomSearchMethod(bool use)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetUseCustomSearchMethod_47(base.GetCppThis(), use ? (byte)1 : (byte)0);
		}

		// Token: 0x0601C66C RID: 116332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_SetUseLogScale_48(HandleRef pThis, byte _arg);

		/// <summary>
		/// Interpolate between the control points in base-10 logrithmic space.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0601C66D RID: 116333 RVA: 0x0027E59D File Offset: 0x0027C79D
		public virtual void SetUseLogScale(bool _arg)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_SetUseLogScale_48(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601C66E RID: 116334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_ShallowCopy_49(HandleRef pThis, HandleRef f);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C66F RID: 116335 RVA: 0x0027E5B8 File Offset: 0x0027C7B8
		public override void ShallowCopy(vtkDataObject f)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_ShallowCopy_49(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		// Token: 0x0601C670 RID: 116336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_UpdateSearchMethod_50(HandleRef pThis, double epsilon, double thresh);

		/// <summary>
		/// Analyses the point distribution and automatically
		/// updates the search method to optimize the time processing
		/// This method assumes that the vector of nodes has been sorted
		/// </summary>
		// Token: 0x0601C671 RID: 116337 RVA: 0x0027E5E7 File Offset: 0x0027C7E7
		public void UpdateSearchMethod(double epsilon, double thresh)
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_UpdateSearchMethod_50(base.GetCppThis(), epsilon, thresh);
		}

		// Token: 0x0601C672 RID: 116338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_UseLogScaleOff_51(HandleRef pThis);

		/// <summary>
		/// Interpolate between the control points in base-10 logrithmic space.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0601C673 RID: 116339 RVA: 0x0027E5F8 File Offset: 0x0027C7F8
		public virtual void UseLogScaleOff()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_UseLogScaleOff_51(base.GetCppThis());
		}

		// Token: 0x0601C674 RID: 116340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPiecewiseFunction_UseLogScaleOn_52(HandleRef pThis);

		/// <summary>
		/// Interpolate between the control points in base-10 logrithmic space.
		/// Default is false.
		/// @{
		/// </summary>
		// Token: 0x0601C675 RID: 116341 RVA: 0x0027E607 File Offset: 0x0027C807
		public virtual void UseLogScaleOn()
		{
			vtkPiecewiseFunction.vtkPiecewiseFunction_UseLogScaleOn_52(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E25 RID: 7717
		public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E26 RID: 7718
		public new static readonly string MRClassNameKey = "class vtkPiecewiseFunction";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000A94 RID: 2708
		public enum SearchMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x04001E28 RID: 7720
			BINARY_SEARCH,
			/// <summary>enum member</summary>
			// Token: 0x04001E29 RID: 7721
			INTERPOLATION_SEARCH,
			/// <summary>enum member</summary>
			// Token: 0x04001E2A RID: 7722
			MAX_ENUM
		}
	}
}
