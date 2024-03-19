using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGElevationResponder
	/// </summary>
	/// <remarks>
	///    Respond to a query on one particular type of cell.
	///
	/// This is pure virtual base class that all responder types must inherit.
	/// </remarks>
	// Token: 0x020004D2 RID: 1234
	public class vtkDGElevationResponder : vtkCellGridResponderBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E098 RID: 57496 RVA: 0x00137A53 File Offset: 0x00135C53
		static vtkDGElevationResponder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGElevationResponder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGElevationResponder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E099 RID: 57497 RVA: 0x00137A7B File Offset: 0x00135C7B
		public vtkDGElevationResponder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E09A RID: 57498
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGElevationResponder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E09B RID: 57499 RVA: 0x00137A8C File Offset: 0x00135C8C
		public new static vtkDGElevationResponder New()
		{
			vtkDGElevationResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGElevationResponder.vtkDGElevationResponder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGElevationResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E09C RID: 57500 RVA: 0x00137AE0 File Offset: 0x00135CE0
		public vtkDGElevationResponder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGElevationResponder.vtkDGElevationResponder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E09D RID: 57501 RVA: 0x00137B24 File Offset: 0x00135D24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E09E RID: 57502
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGElevationResponder_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E09F RID: 57503 RVA: 0x00137B30 File Offset: 0x00135D30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGElevationResponder.vtkDGElevationResponder_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E0A0 RID: 57504
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGElevationResponder_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0A1 RID: 57505 RVA: 0x00137B50 File Offset: 0x00135D50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGElevationResponder.vtkDGElevationResponder_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E0A2 RID: 57506
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGElevationResponder_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0A3 RID: 57507 RVA: 0x00137B6C File Offset: 0x00135D6C
		public override int IsA(string type)
		{
			return vtkDGElevationResponder.vtkDGElevationResponder_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600E0A4 RID: 57508
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGElevationResponder_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0A5 RID: 57509 RVA: 0x00137B8C File Offset: 0x00135D8C
		public new static int IsTypeOf(string type)
		{
			return vtkDGElevationResponder.vtkDGElevationResponder_IsTypeOf_04(type);
		}

		// Token: 0x0600E0A6 RID: 57510
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGElevationResponder_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0A7 RID: 57511 RVA: 0x00137BA8 File Offset: 0x00135DA8
		public new vtkDGElevationResponder NewInstance()
		{
			vtkDGElevationResponder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGElevationResponder.vtkDGElevationResponder_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGElevationResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E0A8 RID: 57512
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGElevationResponder_Query_07(HandleRef pThis, HandleRef query, HandleRef cellType, HandleRef caches);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0A9 RID: 57513 RVA: 0x00137C04 File Offset: 0x00135E04
		public virtual bool Query(vtkCellGridElevationQuery query, vtkCellMetadata cellType, vtkCellGridResponders caches)
		{
			return vtkDGElevationResponder.vtkDGElevationResponder_Query_07(base.GetCppThis(), (query == null) ? default(HandleRef) : query.GetCppThis(), (cellType == null) ? default(HandleRef) : cellType.GetCppThis(), (caches == null) ? default(HandleRef) : caches.GetCppThis()) != 0;
		}

		// Token: 0x0600E0AA RID: 57514
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGElevationResponder_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E0AB RID: 57515 RVA: 0x00137C6C File Offset: 0x00135E6C
		public new static vtkDGElevationResponder SafeDownCast(vtkObjectBase o)
		{
			vtkDGElevationResponder vtkDGElevationResponder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGElevationResponder.vtkDGElevationResponder_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGElevationResponder = (vtkDGElevationResponder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGElevationResponder.Register(null);
				}
			}
			return vtkDGElevationResponder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400107F RID: 4223
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGElevationResponder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001080 RID: 4224
		public new static readonly string MRClassNameKey = "class vtkDGElevationResponder";
	}
}
