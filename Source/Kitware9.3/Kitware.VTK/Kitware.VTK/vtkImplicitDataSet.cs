using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitDataSet
	/// </summary>
	/// <remarks>
	///    treat a dataset as if it were an implicit function
	///
	/// vtkImplicitDataSet treats any type of dataset as if it were an
	/// implicit function. This means it computes a function value and
	/// gradient. vtkImplicitDataSet is a concrete implementation of
	/// vtkImplicitFunction.
	///
	/// vtkImplicitDataSet computes the function (at the point x) by performing
	/// cell interpolation. That is, it finds the cell containing x, and then
	/// uses the cell's interpolation functions to compute an interpolated
	/// scalar value at x. (A similar approach is used to find the
	/// gradient, if requested.) Points outside of the dataset are assigned
	/// the value of the ivar OutValue, and the gradient value OutGradient.
	///
	/// @warning
	/// Any type of dataset can be used as an implicit function as long as it
	/// has scalar data associated with it.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkImplicitVolume vtkClipPolyData vtkCutter
	/// vtkImplicitWindowFunction
	/// </seealso>
	// Token: 0x02000A67 RID: 2663
	public class vtkImplicitDataSet : vtkImplicitFunction
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BE21 RID: 114209 RVA: 0x00270E7F File Offset: 0x0026F07F
		static vtkImplicitDataSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitDataSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitDataSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE22 RID: 114210 RVA: 0x00270EA7 File Offset: 0x0026F0A7
		public vtkImplicitDataSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BE23 RID: 114211
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitDataSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct an vtkImplicitDataSet with no initial dataset; the OutValue
		/// set to a large negative number; and the OutGradient set to (0,0,1).
		/// </summary>
		// Token: 0x0601BE24 RID: 114212 RVA: 0x00270EB8 File Offset: 0x0026F0B8
		public new static vtkImplicitDataSet New()
		{
			vtkImplicitDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct an vtkImplicitDataSet with no initial dataset; the OutValue
		/// set to a large negative number; and the OutGradient set to (0,0,1).
		/// </summary>
		// Token: 0x0601BE25 RID: 114213 RVA: 0x00270F0C File Offset: 0x0026F10C
		public vtkImplicitDataSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitDataSet.vtkImplicitDataSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BE26 RID: 114214 RVA: 0x00270F50 File Offset: 0x0026F150
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BE27 RID: 114215
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitDataSet_EvaluateFunction_01(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate the implicit function. This returns the interpolated scalar value
		/// at x[3].
		/// </summary>
		// Token: 0x0601BE28 RID: 114216 RVA: 0x00270F5C File Offset: 0x0026F15C
		public override double EvaluateFunction(IntPtr x)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_EvaluateFunction_01(base.GetCppThis(), x);
		}

		// Token: 0x0601BE29 RID: 114217
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

		/// <summary>
		/// Evaluate implicit function gradient.
		/// </summary>
		// Token: 0x0601BE2A RID: 114218 RVA: 0x00270F7C File Offset: 0x0026F17C
		public override void EvaluateGradient(IntPtr x, IntPtr n)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_EvaluateGradient_02(base.GetCppThis(), x, n);
		}

		// Token: 0x0601BE2B RID: 114219
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitDataSet_GetDataSet_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the dataset used for the implicit function evaluation.
		/// </summary>
		// Token: 0x0601BE2C RID: 114220 RVA: 0x00270F90 File Offset: 0x0026F190
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_GetDataSet_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601BE2D RID: 114221
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitDataSet_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Return the MTime also considering the DataSet dependency.
		/// </summary>
		// Token: 0x0601BE2E RID: 114222 RVA: 0x00271000 File Offset: 0x0026F200
		public override ulong GetMTime()
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x0601BE2F RID: 114223
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitDataSet_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE30 RID: 114224 RVA: 0x00271020 File Offset: 0x0026F220
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601BE31 RID: 114225
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitDataSet_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE32 RID: 114226 RVA: 0x00271040 File Offset: 0x0026F240
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601BE33 RID: 114227
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitDataSet_GetOutGradient_07(HandleRef pThis);

		/// <summary>
		/// Set / get the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE34 RID: 114228 RVA: 0x0027105C File Offset: 0x0026F25C
		public virtual double[] GetOutGradient()
		{
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_GetOutGradient_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601BE35 RID: 114229
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_GetOutGradient_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set / get the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE36 RID: 114230 RVA: 0x002710A4 File Offset: 0x0026F2A4
		public virtual void GetOutGradient(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_GetOutGradient_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601BE37 RID: 114231
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_GetOutGradient_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE38 RID: 114232 RVA: 0x002710B6 File Offset: 0x0026F2B6
		public virtual void GetOutGradient(IntPtr _arg)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_GetOutGradient_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BE39 RID: 114233
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitDataSet_GetOutValue_10(HandleRef pThis);

		/// <summary>
		/// Set / get the function value to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE3A RID: 114234 RVA: 0x002710C8 File Offset: 0x0026F2C8
		public virtual double GetOutValue()
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_GetOutValue_10(base.GetCppThis());
		}

		// Token: 0x0601BE3B RID: 114235
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitDataSet_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE3C RID: 114236 RVA: 0x002710E8 File Offset: 0x0026F2E8
		public override int IsA(string type)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0601BE3D RID: 114237
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitDataSet_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE3E RID: 114238 RVA: 0x00271108 File Offset: 0x0026F308
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitDataSet.vtkImplicitDataSet_IsTypeOf_12(type);
		}

		// Token: 0x0601BE3F RID: 114239
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitDataSet_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE40 RID: 114240 RVA: 0x00271124 File Offset: 0x0026F324
		public new vtkImplicitDataSet NewInstance()
		{
			vtkImplicitDataSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BE41 RID: 114241
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitDataSet_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BE42 RID: 114242 RVA: 0x00271180 File Offset: 0x0026F380
		public new static vtkImplicitDataSet SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitDataSet vtkImplicitDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitDataSet.vtkImplicitDataSet_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitDataSet = (vtkImplicitDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitDataSet.Register(null);
				}
			}
			return vtkImplicitDataSet;
		}

		// Token: 0x0601BE43 RID: 114243
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_SetDataSet_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the dataset used for the implicit function evaluation.
		/// </summary>
		// Token: 0x0601BE44 RID: 114244 RVA: 0x00271200 File Offset: 0x0026F400
		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetDataSet_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601BE45 RID: 114245
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_SetOutGradient_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set / get the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE46 RID: 114246 RVA: 0x0027122F File Offset: 0x0026F42F
		public virtual void SetOutGradient(double _arg1, double _arg2, double _arg3)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetOutGradient_17(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601BE47 RID: 114247
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_SetOutGradient_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / get the function gradient to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE48 RID: 114248 RVA: 0x00271241 File Offset: 0x0026F441
		public virtual void SetOutGradient(IntPtr _arg)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetOutGradient_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601BE49 RID: 114249
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitDataSet_SetOutValue_19(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the function value to use for points outside of the dataset.
		/// </summary>
		// Token: 0x0601BE4A RID: 114250 RVA: 0x00271251 File Offset: 0x0026F451
		public virtual void SetOutValue(double _arg)
		{
			vtkImplicitDataSet.vtkImplicitDataSet_SetOutValue_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DC5 RID: 7621
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitDataSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DC6 RID: 7622
		public new static readonly string MRClassNameKey = "class vtkImplicitDataSet";
	}
}
