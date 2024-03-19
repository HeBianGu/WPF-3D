using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGTranscribeUnstructuredCells
	/// </summary>
	/// <remarks>
	///    Transcribe unstructured-grid cells as vtkDGCell subclasses.
	///
	/// This class currently only outputs linear geometry but can properly
	/// model higher-order polynomial cell-attributes.
	/// </remarks>
	// Token: 0x020004D6 RID: 1238
	public class vtkDGTranscribeUnstructuredCells : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E0E8 RID: 57576 RVA: 0x001384B3 File Offset: 0x001366B3
		static vtkDGTranscribeUnstructuredCells()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGTranscribeUnstructuredCells.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGTranscribeUnstructuredCells"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0E9 RID: 57577 RVA: 0x001384DB File Offset: 0x001366DB
		public vtkDGTranscribeUnstructuredCells(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E0EA RID: 57578
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTranscribeUnstructuredCells_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0EB RID: 57579 RVA: 0x001384EC File Offset: 0x001366EC
		public new static vtkDGTranscribeUnstructuredCells New()
		{
			vtkDGTranscribeUnstructuredCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGTranscribeUnstructuredCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0EC RID: 57580 RVA: 0x00138540 File Offset: 0x00136740
		public vtkDGTranscribeUnstructuredCells() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E0ED RID: 57581 RVA: 0x00138584 File Offset: 0x00136784
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E0EE RID: 57582
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGTranscribeUnstructuredCells_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0EF RID: 57583 RVA: 0x00138590 File Offset: 0x00136790
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E0F0 RID: 57584
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGTranscribeUnstructuredCells_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0F1 RID: 57585 RVA: 0x001385B0 File Offset: 0x001367B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E0F2 RID: 57586
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTranscribeUnstructuredCells_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0F3 RID: 57587 RVA: 0x001385CC File Offset: 0x001367CC
		public override int IsA(string type)
		{
			return vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E0F4 RID: 57588
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTranscribeUnstructuredCells_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0F5 RID: 57589 RVA: 0x001385EC File Offset: 0x001367EC
		public new static int IsTypeOf(string type)
		{
			return vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_IsTypeOf_04(type);
		}

		// Token: 0x0600E0F6 RID: 57590
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTranscribeUnstructuredCells_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0F7 RID: 57591 RVA: 0x00138608 File Offset: 0x00136808
		public new vtkDGTranscribeUnstructuredCells NewInstance()
		{
			vtkDGTranscribeUnstructuredCells result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGTranscribeUnstructuredCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E0F8 RID: 57592
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTranscribeUnstructuredCells_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0F9 RID: 57593 RVA: 0x00138664 File Offset: 0x00136864
		public new static vtkDGTranscribeUnstructuredCells SafeDownCast(vtkObjectBase o)
		{
			vtkDGTranscribeUnstructuredCells vtkDGTranscribeUnstructuredCells = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTranscribeUnstructuredCells.vtkDGTranscribeUnstructuredCells_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGTranscribeUnstructuredCells = (vtkDGTranscribeUnstructuredCells)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGTranscribeUnstructuredCells.Register(null);
				}
			}
			return vtkDGTranscribeUnstructuredCells;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001087 RID: 4231
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGTranscribeUnstructuredCells";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001088 RID: 4232
		public new static readonly string MRClassNameKey = "class vtkDGTranscribeUnstructuredCells";
	}
}
