using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExplicitStructuredGridAlgorithm
	/// </summary>
	/// <remarks>
	///    Superclass for algorithms that produce only
	/// explicit structured grid as output.
	/// </remarks>
	// Token: 0x02000960 RID: 2400
	public class vtkExplicitStructuredGridAlgorithm : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018F82 RID: 102274 RVA: 0x0022D273 File Offset: 0x0022B473
		static vtkExplicitStructuredGridAlgorithm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExplicitStructuredGridAlgorithm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExplicitStructuredGridAlgorithm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018F83 RID: 102275 RVA: 0x0022D29B File Offset: 0x0022B49B
		public vtkExplicitStructuredGridAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018F84 RID: 102276
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F85 RID: 102277 RVA: 0x0022D2AC File Offset: 0x0022B4AC
		public new static vtkExplicitStructuredGridAlgorithm New()
		{
			vtkExplicitStructuredGridAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F86 RID: 102278 RVA: 0x0022D300 File Offset: 0x0022B500
		public vtkExplicitStructuredGridAlgorithm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018F87 RID: 102279 RVA: 0x0022D344 File Offset: 0x0022B544
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018F88 RID: 102280
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridAlgorithm_AddInputData_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06018F89 RID: 102281 RVA: 0x0022D350 File Offset: 0x0022B550
		public void AddInputData(vtkDataObject arg0)
		{
			vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_AddInputData_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018F8A RID: 102282
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridAlgorithm_AddInputData_02(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use AddInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06018F8B RID: 102283 RVA: 0x0022D380 File Offset: 0x0022B580
		public void AddInputData(int arg0, vtkDataObject arg1)
		{
			vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_AddInputData_02(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06018F8C RID: 102284
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_GetExplicitStructuredGridInput_03(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06018F8D RID: 102285 RVA: 0x0022D3B0 File Offset: 0x0022B5B0
		public vtkExplicitStructuredGrid GetExplicitStructuredGridInput(int port)
		{
			vtkExplicitStructuredGrid vtkExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetExplicitStructuredGridInput_03(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGrid = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGrid;
		}

		// Token: 0x06018F8E RID: 102286
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06018F8F RID: 102287 RVA: 0x0022D420 File Offset: 0x0022B620
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06018F90 RID: 102288
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_GetInput_05(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// see vtkAlgorithm for details
		/// </summary>
		// Token: 0x06018F91 RID: 102289 RVA: 0x0022D490 File Offset: 0x0022B690
		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetInput_05(base.GetCppThis(), port, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x06018F92 RID: 102290
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridAlgorithm_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F93 RID: 102291 RVA: 0x0022D500 File Offset: 0x0022B700
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06018F94 RID: 102292
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExplicitStructuredGridAlgorithm_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F95 RID: 102293 RVA: 0x0022D520 File Offset: 0x0022B720
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06018F96 RID: 102294
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_GetOutput_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06018F97 RID: 102295 RVA: 0x0022D53C File Offset: 0x0022B73C
		public vtkExplicitStructuredGrid GetOutput()
		{
			vtkExplicitStructuredGrid vtkExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetOutput_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGrid = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGrid;
		}

		// Token: 0x06018F98 RID: 102296
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_GetOutput_09(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06018F99 RID: 102297 RVA: 0x0022D5AC File Offset: 0x0022B7AC
		public vtkExplicitStructuredGrid GetOutput(int arg0)
		{
			vtkExplicitStructuredGrid vtkExplicitStructuredGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_GetOutput_09(base.GetCppThis(), arg0, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGrid = (vtkExplicitStructuredGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGrid.Register(null);
				}
			}
			return vtkExplicitStructuredGrid;
		}

		// Token: 0x06018F9A RID: 102298
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridAlgorithm_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F9B RID: 102299 RVA: 0x0022D61C File Offset: 0x0022B81C
		public override int IsA(string type)
		{
			return vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06018F9C RID: 102300
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExplicitStructuredGridAlgorithm_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F9D RID: 102301 RVA: 0x0022D63C File Offset: 0x0022B83C
		public new static int IsTypeOf(string type)
		{
			return vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_IsTypeOf_11(type);
		}

		// Token: 0x06018F9E RID: 102302
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018F9F RID: 102303 RVA: 0x0022D658 File Offset: 0x0022B858
		public new vtkExplicitStructuredGridAlgorithm NewInstance()
		{
			vtkExplicitStructuredGridAlgorithm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExplicitStructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018FA0 RID: 102304
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExplicitStructuredGridAlgorithm_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018FA1 RID: 102305 RVA: 0x0022D6B4 File Offset: 0x0022B8B4
		public new static vtkExplicitStructuredGridAlgorithm SafeDownCast(vtkObjectBase o)
		{
			vtkExplicitStructuredGridAlgorithm vtkExplicitStructuredGridAlgorithm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExplicitStructuredGridAlgorithm = (vtkExplicitStructuredGridAlgorithm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExplicitStructuredGridAlgorithm.Register(null);
				}
			}
			return vtkExplicitStructuredGridAlgorithm;
		}

		// Token: 0x06018FA2 RID: 102306
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridAlgorithm_SetInputData_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06018FA3 RID: 102307 RVA: 0x0022D734 File Offset: 0x0022B934
		public void SetInputData(vtkDataObject arg0)
		{
			vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_SetInputData_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06018FA4 RID: 102308
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridAlgorithm_SetInputData_16(HandleRef pThis, int arg0, HandleRef arg1);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06018FA5 RID: 102309 RVA: 0x0022D764 File Offset: 0x0022B964
		public void SetInputData(int arg0, vtkDataObject arg1)
		{
			vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_SetInputData_16(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x06018FA6 RID: 102310
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExplicitStructuredGridAlgorithm_SetOutput_17(HandleRef pThis, HandleRef d);

		/// <summary>
		/// Get the output data object for a port on this algorithm.
		/// </summary>
		// Token: 0x06018FA7 RID: 102311 RVA: 0x0022D794 File Offset: 0x0022B994
		public virtual void SetOutput(vtkDataObject d)
		{
			vtkExplicitStructuredGridAlgorithm.vtkExplicitStructuredGridAlgorithm_SetOutput_17(base.GetCppThis(), (d == null) ? default(HandleRef) : d.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B79 RID: 7033
		public new const string MRFullTypeName = "Kitware.VTK.vtkExplicitStructuredGridAlgorithm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B7A RID: 7034
		public new static readonly string MRClassNameKey = "class vtkExplicitStructuredGridAlgorithm";
	}
}
