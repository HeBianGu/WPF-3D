using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFunctionSet
	/// </summary>
	/// <remarks>
	///    Abstract interface for sets of functions
	///
	/// vtkFunctionSet specifies an abstract interface for set of functions
	/// of the form F_i = F_i(x_j) where F (with i=1..m) are the functions
	/// and x (with j=1..n) are the independent variables.
	/// The only supported operation is the function evaluation at x_j.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitDataSet vtkCompositeInterpolatedVelocityField vtkAMRInterpolatedVelocityField
	/// vtkInitialValueProblemSolver
	/// </seealso>
	// Token: 0x020004A5 RID: 1189
	public class vtkFunctionSet : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DAF2 RID: 56050 RVA: 0x0012FB1D File Offset: 0x0012DD1D
		static vtkFunctionSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFunctionSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFunctionSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DAF3 RID: 56051 RVA: 0x0012FB45 File Offset: 0x0012DD45
		public vtkFunctionSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DAF4 RID: 56052 RVA: 0x0012FB53 File Offset: 0x0012DD53
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DAF5 RID: 56053
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionSet_FunctionValues_01(HandleRef pThis, IntPtr x, IntPtr f);

		/// <summary>
		/// Evaluate functions at x_j.
		/// x and f have to point to valid double arrays of appropriate
		/// sizes obtained with GetNumberOfFunctions() and
		/// GetNumberOfIndependentVariables.
		/// If you inherit this class, make sure to reimplement at least one of the two
		/// FunctionValues signatures.
		/// </summary>
		// Token: 0x0600DAF6 RID: 56054 RVA: 0x0012FB60 File Offset: 0x0012DD60
		public virtual int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkFunctionSet.vtkFunctionSet_FunctionValues_01(base.GetCppThis(), x, f);
		}

		// Token: 0x0600DAF7 RID: 56055
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionSet_FunctionValues_02(HandleRef pThis, IntPtr x, IntPtr f, IntPtr arg2);

		/// <summary>
		/// Evaluate functions at x_j.
		/// x and f have to point to valid double arrays of appropriate
		/// sizes obtained with GetNumberOfFunctions() and
		/// GetNumberOfIndependentVariables.
		/// If you inherit this class, make sure to reimplement at least one of the two
		/// FunctionValues signatures.
		/// </summary>
		// Token: 0x0600DAF8 RID: 56056 RVA: 0x0012FB84 File Offset: 0x0012DD84
		public virtual int FunctionValues(IntPtr x, IntPtr f, IntPtr arg2)
		{
			return vtkFunctionSet.vtkFunctionSet_FunctionValues_02(base.GetCppThis(), x, f, arg2);
		}

		// Token: 0x0600DAF9 RID: 56057
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionSet_GetNumberOfFunctions_03(HandleRef pThis);

		/// <summary>
		/// Return the number of functions. Note that this is constant for
		/// a given type of set of functions and can not be changed at
		/// run time.
		/// </summary>
		// Token: 0x0600DAFA RID: 56058 RVA: 0x0012FBA8 File Offset: 0x0012DDA8
		public virtual int GetNumberOfFunctions()
		{
			return vtkFunctionSet.vtkFunctionSet_GetNumberOfFunctions_03(base.GetCppThis());
		}

		// Token: 0x0600DAFB RID: 56059
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFunctionSet_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DAFC RID: 56060 RVA: 0x0012FBC8 File Offset: 0x0012DDC8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFunctionSet.vtkFunctionSet_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600DAFD RID: 56061
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFunctionSet_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DAFE RID: 56062 RVA: 0x0012FBE8 File Offset: 0x0012DDE8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFunctionSet.vtkFunctionSet_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600DAFF RID: 56063
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionSet_GetNumberOfIndependentVariables_06(HandleRef pThis);

		/// <summary>
		/// Return the number of independent variables. Note that this is
		/// constant for a given type of set of functions and can not be changed
		/// at run time.
		/// </summary>
		// Token: 0x0600DB00 RID: 56064 RVA: 0x0012FC04 File Offset: 0x0012DE04
		public virtual int GetNumberOfIndependentVariables()
		{
			return vtkFunctionSet.vtkFunctionSet_GetNumberOfIndependentVariables_06(base.GetCppThis());
		}

		// Token: 0x0600DB01 RID: 56065
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionSet_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB02 RID: 56066 RVA: 0x0012FC24 File Offset: 0x0012DE24
		public override int IsA(string type)
		{
			return vtkFunctionSet.vtkFunctionSet_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600DB03 RID: 56067
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFunctionSet_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB04 RID: 56068 RVA: 0x0012FC44 File Offset: 0x0012DE44
		public new static int IsTypeOf(string type)
		{
			return vtkFunctionSet.vtkFunctionSet_IsTypeOf_08(type);
		}

		// Token: 0x0600DB05 RID: 56069
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionSet_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB06 RID: 56070 RVA: 0x0012FC60 File Offset: 0x0012DE60
		public new vtkFunctionSet NewInstance()
		{
			vtkFunctionSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFunctionSet.vtkFunctionSet_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DB07 RID: 56071
		[DllImport("Kitware.VTK.CommonMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFunctionSet_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB08 RID: 56072 RVA: 0x0012FCBC File Offset: 0x0012DEBC
		public new static vtkFunctionSet SafeDownCast(vtkObjectBase o)
		{
			vtkFunctionSet vtkFunctionSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFunctionSet.vtkFunctionSet_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFunctionSet = (vtkFunctionSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFunctionSet.Register(null);
				}
			}
			return vtkFunctionSet;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FFF RID: 4095
		public new const string MRFullTypeName = "Kitware.VTK.vtkFunctionSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001000 RID: 4096
		public new static readonly string MRClassNameKey = "class vtkFunctionSet";
	}
}
