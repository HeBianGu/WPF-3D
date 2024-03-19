using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContextMapper2D
	/// </summary>
	/// <remarks>
	///    Abstract class for 2D context mappers.
	///
	///
	///
	/// This class provides an abstract base for 2D context mappers. They currently
	/// only accept vtkTable objects as input.
	/// </remarks>
	// Token: 0x020007AE RID: 1966
	public class vtkContextMapper2D : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060142F3 RID: 82675 RVA: 0x001C849A File Offset: 0x001C669A
		static vtkContextMapper2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContextMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContextMapper2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060142F4 RID: 82676 RVA: 0x001C84C2 File Offset: 0x001C66C2
		public vtkContextMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060142F5 RID: 82677
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142F6 RID: 82678 RVA: 0x001C84D0 File Offset: 0x001C66D0
		public new static vtkContextMapper2D New()
		{
			vtkContextMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060142F7 RID: 82679 RVA: 0x001C8524 File Offset: 0x001C6724
		public vtkContextMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkContextMapper2D.vtkContextMapper2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060142F8 RID: 82680 RVA: 0x001C8568 File Offset: 0x001C6768
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060142F9 RID: 82681
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextMapper2D_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the input for this object - only accepts vtkTable as input.
		/// </summary>
		// Token: 0x060142FA RID: 82682 RVA: 0x001C8574 File Offset: 0x001C6774
		public virtual vtkTable GetInput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x060142FB RID: 82683
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextMapper2D_GetInputAbstractArrayToProcess_02(HandleRef pThis, int idx, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make the arrays accessible to the plot objects.
		/// </summary>
		// Token: 0x060142FC RID: 82684 RVA: 0x001C85E4 File Offset: 0x001C67E4
		public vtkAbstractArray GetInputAbstractArrayToProcess(int idx, vtkDataObject input)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_GetInputAbstractArrayToProcess_02(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x060142FD RID: 82685
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextMapper2D_GetInputArrayToProcess_03(HandleRef pThis, int idx, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make the arrays accessible to the plot objects.
		/// </summary>
		// Token: 0x060142FE RID: 82686 RVA: 0x001C866C File Offset: 0x001C686C
		public vtkDataArray GetInputArrayToProcess(int idx, vtkDataObject input)
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_GetInputArrayToProcess_03(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x060142FF RID: 82687
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextMapper2D_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014300 RID: 82688 RVA: 0x001C86F4 File Offset: 0x001C68F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContextMapper2D.vtkContextMapper2D_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06014301 RID: 82689
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContextMapper2D_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014302 RID: 82690 RVA: 0x001C8714 File Offset: 0x001C6914
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContextMapper2D.vtkContextMapper2D_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06014303 RID: 82691
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextMapper2D_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014304 RID: 82692 RVA: 0x001C8730 File Offset: 0x001C6930
		public override int IsA(string type)
		{
			return vtkContextMapper2D.vtkContextMapper2D_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06014305 RID: 82693
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContextMapper2D_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014306 RID: 82694 RVA: 0x001C8750 File Offset: 0x001C6950
		public new static int IsTypeOf(string type)
		{
			return vtkContextMapper2D.vtkContextMapper2D_IsTypeOf_07(type);
		}

		// Token: 0x06014307 RID: 82695
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextMapper2D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014308 RID: 82696 RVA: 0x001C876C File Offset: 0x001C696C
		public new vtkContextMapper2D NewInstance()
		{
			vtkContextMapper2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014309 RID: 82697
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContextMapper2D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601430A RID: 82698 RVA: 0x001C87C8 File Offset: 0x001C69C8
		public new static vtkContextMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkContextMapper2D vtkContextMapper2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContextMapper2D.vtkContextMapper2D_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContextMapper2D = (vtkContextMapper2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContextMapper2D.Register(null);
				}
			}
			return vtkContextMapper2D;
		}

		// Token: 0x0601430B RID: 82699
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContextMapper2D_SetInputData_11(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set/Get the input for this object - only accepts vtkTable as input.
		/// </summary>
		// Token: 0x0601430C RID: 82700 RVA: 0x001C8848 File Offset: 0x001C6A48
		public virtual void SetInputData(vtkTable input)
		{
			vtkContextMapper2D.vtkContextMapper2D_SetInputData_11(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001768 RID: 5992
		public new const string MRFullTypeName = "Kitware.VTK.vtkContextMapper2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001769 RID: 5993
		public new static readonly string MRClassNameKey = "class vtkContextMapper2D";
	}
}
