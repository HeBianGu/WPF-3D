using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLogLookupTable
	/// </summary>
	/// <remarks>
	///    map scalars into colors using log (base 10) scale
	///
	/// This class is an empty shell.  Use vtkLookupTable with SetScaleToLog10()
	/// instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLookupTable
	/// </seealso>
	// Token: 0x020007F1 RID: 2033
	public class vtkLogLookupTable : vtkLookupTable
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014E86 RID: 85638 RVA: 0x001D9191 File Offset: 0x001D7391
		static vtkLogLookupTable()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLogLookupTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLogLookupTable"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014E87 RID: 85639 RVA: 0x001D91B9 File Offset: 0x001D73B9
		public vtkLogLookupTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014E88 RID: 85640
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogLookupTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E89 RID: 85641 RVA: 0x001D91C8 File Offset: 0x001D73C8
		public new static vtkLogLookupTable New()
		{
			vtkLogLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogLookupTable.vtkLogLookupTable_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E8A RID: 85642 RVA: 0x001D921C File Offset: 0x001D741C
		public vtkLogLookupTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLogLookupTable.vtkLogLookupTable_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014E8B RID: 85643 RVA: 0x001D9260 File Offset: 0x001D7460
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014E8C RID: 85644
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLogLookupTable_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E8D RID: 85645 RVA: 0x001D926C File Offset: 0x001D746C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLogLookupTable.vtkLogLookupTable_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06014E8E RID: 85646
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLogLookupTable_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E8F RID: 85647 RVA: 0x001D928C File Offset: 0x001D748C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLogLookupTable.vtkLogLookupTable_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06014E90 RID: 85648
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogLookupTable_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E91 RID: 85649 RVA: 0x001D92A8 File Offset: 0x001D74A8
		public override int IsA(string type)
		{
			return vtkLogLookupTable.vtkLogLookupTable_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06014E92 RID: 85650
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLogLookupTable_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E93 RID: 85651 RVA: 0x001D92C8 File Offset: 0x001D74C8
		public new static int IsTypeOf(string type)
		{
			return vtkLogLookupTable.vtkLogLookupTable_IsTypeOf_04(type);
		}

		// Token: 0x06014E94 RID: 85652
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogLookupTable_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E95 RID: 85653 RVA: 0x001D92E4 File Offset: 0x001D74E4
		public new vtkLogLookupTable NewInstance()
		{
			vtkLogLookupTable result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogLookupTable.vtkLogLookupTable_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLogLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014E96 RID: 85654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLogLookupTable_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E97 RID: 85655 RVA: 0x001D9340 File Offset: 0x001D7540
		public new static vtkLogLookupTable SafeDownCast(vtkObjectBase o)
		{
			vtkLogLookupTable vtkLogLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLogLookupTable.vtkLogLookupTable_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLogLookupTable = (vtkLogLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLogLookupTable.Register(null);
				}
			}
			return vtkLogLookupTable;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001821 RID: 6177
		public new const string MRFullTypeName = "Kitware.VTK.vtkLogLookupTable";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001822 RID: 6178
		public new static readonly string MRClassNameKey = "class vtkLogLookupTable";
	}
}
