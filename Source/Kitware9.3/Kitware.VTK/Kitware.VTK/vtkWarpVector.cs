using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWarpVector
	/// </summary>
	/// <remarks>
	///    deform geometry with vector data
	///
	/// vtkWarpVector is a filter that modifies point coordinates by moving
	/// points along vector times the scale factor. Useful for showing flow
	/// profiles or mechanical deformation.
	///
	/// The filter passes both its point data and cell data to its output.
	/// </remarks>
	// Token: 0x020008FC RID: 2300
	public class vtkWarpVector : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017C1B RID: 97307 RVA: 0x00214EB5 File Offset: 0x002130B5
		static vtkWarpVector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpVector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpVector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017C1C RID: 97308 RVA: 0x00214EDD File Offset: 0x002130DD
		public vtkWarpVector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017C1D RID: 97309
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpVector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C1E RID: 97310 RVA: 0x00214EEC File Offset: 0x002130EC
		public new static vtkWarpVector New()
		{
			vtkWarpVector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpVector.vtkWarpVector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C1F RID: 97311 RVA: 0x00214F40 File Offset: 0x00213140
		public vtkWarpVector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWarpVector.vtkWarpVector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017C20 RID: 97312 RVA: 0x00214F84 File Offset: 0x00213184
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017C21 RID: 97313
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpVector_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Set/get the desired precision for the output points type. By default
		/// (DEFAULT_PRECISION) the output type is the same as the input points
		/// type. Otherwise, specify the precision as SINGLE_PRECISION or
		/// DOUBLE_PRECISION.
		/// </summary>
		// Token: 0x06017C22 RID: 97314 RVA: 0x00214F90 File Offset: 0x00213190
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkWarpVector.vtkWarpVector_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x06017C23 RID: 97315
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpVector_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C24 RID: 97316 RVA: 0x00214FC8 File Offset: 0x002131C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWarpVector.vtkWarpVector_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06017C25 RID: 97317
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWarpVector_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C26 RID: 97318 RVA: 0x00214FE8 File Offset: 0x002131E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWarpVector.vtkWarpVector_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06017C27 RID: 97319
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpVector_GetOutputPointsPrecision_04(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output points type. By default
		/// (DEFAULT_PRECISION) the output type is the same as the input points
		/// type. Otherwise, specify the precision as SINGLE_PRECISION or
		/// DOUBLE_PRECISION.
		/// </summary>
		// Token: 0x06017C28 RID: 97320 RVA: 0x00215004 File Offset: 0x00213204
		public virtual int GetOutputPointsPrecision()
		{
			return vtkWarpVector.vtkWarpVector_GetOutputPointsPrecision_04(base.GetCppThis());
		}

		// Token: 0x06017C29 RID: 97321
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkWarpVector_GetScaleFactor_05(HandleRef pThis);

		/// <summary>
		/// Specify value to scale displacement.
		/// </summary>
		// Token: 0x06017C2A RID: 97322 RVA: 0x00215024 File Offset: 0x00213224
		public virtual double GetScaleFactor()
		{
			return vtkWarpVector.vtkWarpVector_GetScaleFactor_05(base.GetCppThis());
		}

		// Token: 0x06017C2B RID: 97323
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpVector_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C2C RID: 97324 RVA: 0x00215044 File Offset: 0x00213244
		public override int IsA(string type)
		{
			return vtkWarpVector.vtkWarpVector_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017C2D RID: 97325
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWarpVector_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C2E RID: 97326 RVA: 0x00215064 File Offset: 0x00213264
		public new static int IsTypeOf(string type)
		{
			return vtkWarpVector.vtkWarpVector_IsTypeOf_07(type);
		}

		// Token: 0x06017C2F RID: 97327
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpVector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C30 RID: 97328 RVA: 0x00215080 File Offset: 0x00213280
		public new vtkWarpVector NewInstance()
		{
			vtkWarpVector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpVector.vtkWarpVector_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017C31 RID: 97329
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWarpVector_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information,
		/// and printing.
		/// </summary>
		// Token: 0x06017C32 RID: 97330 RVA: 0x002150DC File Offset: 0x002132DC
		public new static vtkWarpVector SafeDownCast(vtkObjectBase o)
		{
			vtkWarpVector vtkWarpVector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWarpVector.vtkWarpVector_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpVector = (vtkWarpVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpVector.Register(null);
				}
			}
			return vtkWarpVector;
		}

		// Token: 0x06017C33 RID: 97331
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpVector_SetOutputPointsPrecision_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output points type. By default
		/// (DEFAULT_PRECISION) the output type is the same as the input points
		/// type. Otherwise, specify the precision as SINGLE_PRECISION or
		/// DOUBLE_PRECISION.
		/// </summary>
		// Token: 0x06017C34 RID: 97332 RVA: 0x0021515B File Offset: 0x0021335B
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkWarpVector.vtkWarpVector_SetOutputPointsPrecision_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06017C35 RID: 97333
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWarpVector_SetScaleFactor_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify value to scale displacement.
		/// </summary>
		// Token: 0x06017C36 RID: 97334 RVA: 0x0021516B File Offset: 0x0021336B
		public virtual void SetScaleFactor(double _arg)
		{
			vtkWarpVector.vtkWarpVector_SetScaleFactor_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A77 RID: 6775
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpVector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A78 RID: 6776
		public new static readonly string MRClassNameKey = "class vtkWarpVector";
	}
}
