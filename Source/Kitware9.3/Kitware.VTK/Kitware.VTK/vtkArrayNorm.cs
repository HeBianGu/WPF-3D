using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayNorm
	/// </summary>
	/// <remarks>
	///    Computes L-norms along one dimension of an array.
	///
	///
	/// Given an input matrix (vtkTypedArray&lt;double&gt;), computes the L-norm for each
	/// vector along either dimension, storing the results in a dense output
	/// vector (1D vtkDenseArray&lt;double&gt;).  The caller may optionally request the
	/// inverse norm as output (useful for subsequent normalization), and may limit
	/// the computation to a "window" of vector elements, to avoid data copying.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000672 RID: 1650
	public class vtkArrayNorm : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011CAF RID: 72879 RVA: 0x0018E500 File Offset: 0x0018C700
		static vtkArrayNorm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayNorm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayNorm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011CB0 RID: 72880 RVA: 0x0018E528 File Offset: 0x0018C728
		public vtkArrayNorm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011CB1 RID: 72881
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayNorm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CB2 RID: 72882 RVA: 0x0018E538 File Offset: 0x0018C738
		public new static vtkArrayNorm New()
		{
			vtkArrayNorm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayNorm.vtkArrayNorm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayNorm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CB3 RID: 72883 RVA: 0x0018E58C File Offset: 0x0018C78C
		public vtkArrayNorm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayNorm.vtkArrayNorm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011CB4 RID: 72884 RVA: 0x0018E5D0 File Offset: 0x0018C7D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011CB5 RID: 72885
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayNorm_GetDimension_01(HandleRef pThis);

		/// <summary>
		/// Controls the dimension along which norms will be computed.  For input matrices,
		/// For input matrices, use "0" (rows) or "1" (columns). Default: 0
		/// </summary>
		// Token: 0x06011CB6 RID: 72886 RVA: 0x0018E5DC File Offset: 0x0018C7DC
		public virtual int GetDimension()
		{
			return vtkArrayNorm.vtkArrayNorm_GetDimension_01(base.GetCppThis());
		}

		// Token: 0x06011CB7 RID: 72887
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayNorm_GetInvert_02(HandleRef pThis);

		/// <summary>
		/// Controls whether to invert output values.  Default: false
		/// </summary>
		// Token: 0x06011CB8 RID: 72888 RVA: 0x0018E5FC File Offset: 0x0018C7FC
		public virtual int GetInvert()
		{
			return vtkArrayNorm.vtkArrayNorm_GetInvert_02(base.GetCppThis());
		}

		// Token: 0x06011CB9 RID: 72889
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayNorm_GetL_03(HandleRef pThis);

		/// <summary>
		/// Controls the L-value.  Default: 2
		/// </summary>
		// Token: 0x06011CBA RID: 72890 RVA: 0x0018E61C File Offset: 0x0018C81C
		public virtual int GetL()
		{
			return vtkArrayNorm.vtkArrayNorm_GetL_03(base.GetCppThis());
		}

		// Token: 0x06011CBB RID: 72891
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayNorm_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CBC RID: 72892 RVA: 0x0018E63C File Offset: 0x0018C83C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayNorm.vtkArrayNorm_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06011CBD RID: 72893
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayNorm_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CBE RID: 72894 RVA: 0x0018E65C File Offset: 0x0018C85C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayNorm.vtkArrayNorm_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06011CBF RID: 72895
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayNorm_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CC0 RID: 72896 RVA: 0x0018E678 File Offset: 0x0018C878
		public override int IsA(string type)
		{
			return vtkArrayNorm.vtkArrayNorm_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06011CC1 RID: 72897
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayNorm_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CC2 RID: 72898 RVA: 0x0018E698 File Offset: 0x0018C898
		public new static int IsTypeOf(string type)
		{
			return vtkArrayNorm.vtkArrayNorm_IsTypeOf_07(type);
		}

		// Token: 0x06011CC3 RID: 72899
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayNorm_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CC4 RID: 72900 RVA: 0x0018E6B4 File Offset: 0x0018C8B4
		public new vtkArrayNorm NewInstance()
		{
			vtkArrayNorm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayNorm.vtkArrayNorm_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayNorm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011CC5 RID: 72901
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayNorm_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CC6 RID: 72902 RVA: 0x0018E710 File Offset: 0x0018C910
		public new static vtkArrayNorm SafeDownCast(vtkObjectBase o)
		{
			vtkArrayNorm vtkArrayNorm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayNorm.vtkArrayNorm_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayNorm = (vtkArrayNorm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayNorm.Register(null);
				}
			}
			return vtkArrayNorm;
		}

		// Token: 0x06011CC7 RID: 72903
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayNorm_SetDimension_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls the dimension along which norms will be computed.  For input matrices,
		/// For input matrices, use "0" (rows) or "1" (columns). Default: 0
		/// </summary>
		// Token: 0x06011CC8 RID: 72904 RVA: 0x0018E78F File Offset: 0x0018C98F
		public virtual void SetDimension(int _arg)
		{
			vtkArrayNorm.vtkArrayNorm_SetDimension_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06011CC9 RID: 72905
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayNorm_SetInvert_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls whether to invert output values.  Default: false
		/// </summary>
		// Token: 0x06011CCA RID: 72906 RVA: 0x0018E79F File Offset: 0x0018C99F
		public virtual void SetInvert(int _arg)
		{
			vtkArrayNorm.vtkArrayNorm_SetInvert_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06011CCB RID: 72907
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayNorm_SetL_13(HandleRef pThis, int value);

		/// <summary>
		/// Controls the L-value.  Default: 2
		/// </summary>
		// Token: 0x06011CCC RID: 72908 RVA: 0x0018E7AF File Offset: 0x0018C9AF
		public void SetL(int value)
		{
			vtkArrayNorm.vtkArrayNorm_SetL_13(base.GetCppThis(), value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001485 RID: 5253
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayNorm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001486 RID: 5254
		public new static readonly string MRClassNameKey = "class vtkArrayNorm";
	}
}
