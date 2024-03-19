using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellDerivatives
	/// </summary>
	/// <remarks>
	///    compute derivatives of scalars and vectors
	///
	/// vtkCellDerivatives is a filter that computes derivatives of scalars
	/// and vectors at the center of cells. You can choose to generate
	/// different output including the scalar gradient (a vector), computed
	/// tensor vorticity (a vector), gradient of input vectors (a tensor),
	/// and strain matrix (linearized or Green-Lagrange) of the input vectors
	/// (a tensor); or you may choose to pass data through to the output.
	///
	/// Note that it is assumed that on input scalars and vector point data
	/// is available, which are then used to generate cell vectors and tensors.
	/// (The interpolation functions of the cells are used to compute the
	/// derivatives which is why point data is required.)
	///
	/// Note that the tensor components used to be sent out in column, but they
	/// are now sent out not in row.
	///
	/// @warning
	/// The computed derivatives are cell attribute data; you can convert them to
	/// point attribute data by using the vtkCellDataToPointData filter.
	/// Note that, due to the interpolation function used (obtained using
	/// 1/r**2 normalized sum), the derivatives calculated for polygons
	/// with more than 4 vertices are inaccurate in most cases.
	///
	/// @warning
	/// The point data is passed through the filter to the output.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkVectorNorm
	/// </seealso>
	// Token: 0x0200087B RID: 2171
	public class vtkCellDerivatives : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016854 RID: 92244 RVA: 0x001FAFEF File Offset: 0x001F91EF
		static vtkCellDerivatives()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellDerivatives.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellDerivatives"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016855 RID: 92245 RVA: 0x001FB017 File Offset: 0x001F9217
		public vtkCellDerivatives(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016856 RID: 92246
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDerivatives_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct to compute the gradient of the scalars and vectors.
		/// </summary>
		// Token: 0x06016857 RID: 92247 RVA: 0x001FB028 File Offset: 0x001F9228
		public new static vtkCellDerivatives New()
		{
			vtkCellDerivatives result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDerivatives.vtkCellDerivatives_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct to compute the gradient of the scalars and vectors.
		/// </summary>
		// Token: 0x06016858 RID: 92248 RVA: 0x001FB07C File Offset: 0x001F927C
		public vtkCellDerivatives() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellDerivatives.vtkCellDerivatives_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016859 RID: 92249 RVA: 0x001FB0C0 File Offset: 0x001F92C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601685A RID: 92250
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellDerivatives_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601685B RID: 92251 RVA: 0x001FB0CC File Offset: 0x001F92CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellDerivatives.vtkCellDerivatives_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601685C RID: 92252
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellDerivatives_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601685D RID: 92253 RVA: 0x001FB0EC File Offset: 0x001F92EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellDerivatives.vtkCellDerivatives_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601685E RID: 92254
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDerivatives_GetTensorMode_03(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x0601685F RID: 92255 RVA: 0x001FB108 File Offset: 0x001F9308
		public virtual int GetTensorMode()
		{
			return vtkCellDerivatives.vtkCellDerivatives_GetTensorMode_03(base.GetCppThis());
		}

		// Token: 0x06016860 RID: 92256
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDerivatives_GetTensorModeAsString_04(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x06016861 RID: 92257 RVA: 0x001FB128 File Offset: 0x001F9328
		public string GetTensorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellDerivatives.vtkCellDerivatives_GetTensorModeAsString_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016862 RID: 92258
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDerivatives_GetVectorMode_05(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate vector cell data. You
		/// can choose to pass the input cell vectors, compute the gradient
		/// of the input scalars, or extract the vorticity of the computed
		/// vector gradient tensor. By default (VectorModeToComputeGradient),
		/// the filter will take the gradient of the input scalar data.
		/// </summary>
		// Token: 0x06016863 RID: 92259 RVA: 0x001FB164 File Offset: 0x001F9364
		public virtual int GetVectorMode()
		{
			return vtkCellDerivatives.vtkCellDerivatives_GetVectorMode_05(base.GetCppThis());
		}

		// Token: 0x06016864 RID: 92260
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDerivatives_GetVectorModeAsString_06(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate vector cell data. You
		/// can choose to pass the input cell vectors, compute the gradient
		/// of the input scalars, or extract the vorticity of the computed
		/// vector gradient tensor. By default (VectorModeToComputeGradient),
		/// the filter will take the gradient of the input scalar data.
		/// </summary>
		// Token: 0x06016865 RID: 92261 RVA: 0x001FB184 File Offset: 0x001F9384
		public string GetVectorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellDerivatives.vtkCellDerivatives_GetVectorModeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016866 RID: 92262
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDerivatives_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06016867 RID: 92263 RVA: 0x001FB1C0 File Offset: 0x001F93C0
		public override int IsA(string type)
		{
			return vtkCellDerivatives.vtkCellDerivatives_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06016868 RID: 92264
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellDerivatives_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x06016869 RID: 92265 RVA: 0x001FB1E0 File Offset: 0x001F93E0
		public new static int IsTypeOf(string type)
		{
			return vtkCellDerivatives.vtkCellDerivatives_IsTypeOf_08(type);
		}

		// Token: 0x0601686A RID: 92266
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDerivatives_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601686B RID: 92267 RVA: 0x001FB1FC File Offset: 0x001F93FC
		public new vtkCellDerivatives NewInstance()
		{
			vtkCellDerivatives result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDerivatives.vtkCellDerivatives_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601686C RID: 92268
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellDerivatives_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601686D RID: 92269 RVA: 0x001FB258 File Offset: 0x001F9458
		public new static vtkCellDerivatives SafeDownCast(vtkObjectBase o)
		{
			vtkCellDerivatives vtkCellDerivatives = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellDerivatives.vtkCellDerivatives_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellDerivatives = (vtkCellDerivatives)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellDerivatives.Register(null);
				}
			}
			return vtkCellDerivatives;
		}

		// Token: 0x0601686E RID: 92270
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetTensorMode_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x0601686F RID: 92271 RVA: 0x001FB2D7 File Offset: 0x001F94D7
		public virtual void SetTensorMode(int _arg)
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorMode_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06016870 RID: 92272
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetTensorModeToComputeGradient_13(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x06016871 RID: 92273 RVA: 0x001FB2E7 File Offset: 0x001F94E7
		public void SetTensorModeToComputeGradient()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToComputeGradient_13(base.GetCppThis());
		}

		// Token: 0x06016872 RID: 92274
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetTensorModeToComputeGreenLagrangeStrain_14(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x06016873 RID: 92275 RVA: 0x001FB2F6 File Offset: 0x001F94F6
		public void SetTensorModeToComputeGreenLagrangeStrain()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToComputeGreenLagrangeStrain_14(base.GetCppThis());
		}

		// Token: 0x06016874 RID: 92276
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetTensorModeToComputeStrain_15(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x06016875 RID: 92277 RVA: 0x001FB305 File Offset: 0x001F9505
		public void SetTensorModeToComputeStrain()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToComputeStrain_15(base.GetCppThis());
		}

		// Token: 0x06016876 RID: 92278
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetTensorModeToPassTensors_16(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate tensor cell data. You can
		/// choose to pass the input cell tensors, compute the gradient of
		/// the input vectors, or compute the strain tensor (linearized or
		/// Green-Lagrange strain)of the vector gradient tensor. By default
		/// (TensorModeToComputeGradient), the filter will take the gradient
		/// of the vector data to construct a tensor.
		/// </summary>
		// Token: 0x06016877 RID: 92279 RVA: 0x001FB314 File Offset: 0x001F9514
		public void SetTensorModeToPassTensors()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetTensorModeToPassTensors_16(base.GetCppThis());
		}

		// Token: 0x06016878 RID: 92280
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetVectorMode_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the filter works to generate vector cell data. You
		/// can choose to pass the input cell vectors, compute the gradient
		/// of the input scalars, or extract the vorticity of the computed
		/// vector gradient tensor. By default (VectorModeToComputeGradient),
		/// the filter will take the gradient of the input scalar data.
		/// </summary>
		// Token: 0x06016879 RID: 92281 RVA: 0x001FB323 File Offset: 0x001F9523
		public virtual void SetVectorMode(int _arg)
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorMode_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601687A RID: 92282
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetVectorModeToComputeGradient_18(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate vector cell data. You
		/// can choose to pass the input cell vectors, compute the gradient
		/// of the input scalars, or extract the vorticity of the computed
		/// vector gradient tensor. By default (VectorModeToComputeGradient),
		/// the filter will take the gradient of the input scalar data.
		/// </summary>
		// Token: 0x0601687B RID: 92283 RVA: 0x001FB333 File Offset: 0x001F9533
		public void SetVectorModeToComputeGradient()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorModeToComputeGradient_18(base.GetCppThis());
		}

		// Token: 0x0601687C RID: 92284
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetVectorModeToComputeVorticity_19(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate vector cell data. You
		/// can choose to pass the input cell vectors, compute the gradient
		/// of the input scalars, or extract the vorticity of the computed
		/// vector gradient tensor. By default (VectorModeToComputeGradient),
		/// the filter will take the gradient of the input scalar data.
		/// </summary>
		// Token: 0x0601687D RID: 92285 RVA: 0x001FB342 File Offset: 0x001F9542
		public void SetVectorModeToComputeVorticity()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorModeToComputeVorticity_19(base.GetCppThis());
		}

		// Token: 0x0601687E RID: 92286
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellDerivatives_SetVectorModeToPassVectors_20(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate vector cell data. You
		/// can choose to pass the input cell vectors, compute the gradient
		/// of the input scalars, or extract the vorticity of the computed
		/// vector gradient tensor. By default (VectorModeToComputeGradient),
		/// the filter will take the gradient of the input scalar data.
		/// </summary>
		// Token: 0x0601687F RID: 92287 RVA: 0x001FB351 File Offset: 0x001F9551
		public void SetVectorModeToPassVectors()
		{
			vtkCellDerivatives.vtkCellDerivatives_SetVectorModeToPassVectors_20(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400194E RID: 6478
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellDerivatives";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400194F RID: 6479
		public new static readonly string MRClassNameKey = "class vtkCellDerivatives";
	}
}
