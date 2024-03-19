using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTransmitRectilinearGridPiece
	/// </summary>
	/// <remarks>
	///    Redistributes data produced
	/// by serial readers
	///
	///
	/// This filter can be used to redistribute data from producers that can't
	/// produce data in parallel. All data is produced on first process and
	/// the distributed to others using the multiprocess controller.
	///
	/// Note that this class is legacy. The superclass does all the work and
	/// can be used directly instead.
	/// </remarks>
	// Token: 0x0200047C RID: 1148
	public class vtkTransmitImageDataPiece : vtkTransmitStructuredDataPiece
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D375 RID: 54133 RVA: 0x001265B3 File Offset: 0x001247B3
		static vtkTransmitImageDataPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitImageDataPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitImageDataPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D376 RID: 54134 RVA: 0x001265DB File Offset: 0x001247DB
		public vtkTransmitImageDataPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D377 RID: 54135
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitImageDataPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D378 RID: 54136 RVA: 0x001265EC File Offset: 0x001247EC
		public new static vtkTransmitImageDataPiece New()
		{
			vtkTransmitImageDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitImageDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D379 RID: 54137 RVA: 0x00126640 File Offset: 0x00124840
		public vtkTransmitImageDataPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D37A RID: 54138 RVA: 0x00126684 File Offset: 0x00124884
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D37B RID: 54139
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitImageDataPiece_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D37C RID: 54140 RVA: 0x00126690 File Offset: 0x00124890
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D37D RID: 54141
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitImageDataPiece_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D37E RID: 54142 RVA: 0x001266B0 File Offset: 0x001248B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D37F RID: 54143
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitImageDataPiece_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D380 RID: 54144 RVA: 0x001266CC File Offset: 0x001248CC
		public override int IsA(string type)
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D381 RID: 54145
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitImageDataPiece_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D382 RID: 54146 RVA: 0x001266EC File Offset: 0x001248EC
		public new static int IsTypeOf(string type)
		{
			return vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_IsTypeOf_04(type);
		}

		// Token: 0x0600D383 RID: 54147
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitImageDataPiece_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D384 RID: 54148 RVA: 0x00126708 File Offset: 0x00124908
		public new vtkTransmitImageDataPiece NewInstance()
		{
			vtkTransmitImageDataPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitImageDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D385 RID: 54149
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitImageDataPiece_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D386 RID: 54150 RVA: 0x00126764 File Offset: 0x00124964
		public new static vtkTransmitImageDataPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitImageDataPiece vtkTransmitImageDataPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitImageDataPiece.vtkTransmitImageDataPiece_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitImageDataPiece = (vtkTransmitImageDataPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitImageDataPiece.Register(null);
				}
			}
			return vtkTransmitImageDataPiece;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA0 RID: 4000
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitImageDataPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FA1 RID: 4001
		public new static readonly string MRClassNameKey = "class vtkTransmitImageDataPiece";
	}
}
