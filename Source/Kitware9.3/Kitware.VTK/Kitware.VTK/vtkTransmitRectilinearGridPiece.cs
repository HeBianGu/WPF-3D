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
	// Token: 0x0200053C RID: 1340
	public class vtkTransmitRectilinearGridPiece : vtkTransmitStructuredDataPiece
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EEC7 RID: 61127 RVA: 0x0014CC73 File Offset: 0x0014AE73
		static vtkTransmitRectilinearGridPiece()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTransmitRectilinearGridPiece.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTransmitRectilinearGridPiece"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EEC8 RID: 61128 RVA: 0x0014CC9B File Offset: 0x0014AE9B
		public vtkTransmitRectilinearGridPiece(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EEC9 RID: 61129
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EECA RID: 61130 RVA: 0x0014CCAC File Offset: 0x0014AEAC
		public new static vtkTransmitRectilinearGridPiece New()
		{
			vtkTransmitRectilinearGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitRectilinearGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EECB RID: 61131 RVA: 0x0014CD00 File Offset: 0x0014AF00
		public vtkTransmitRectilinearGridPiece() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EECC RID: 61132 RVA: 0x0014CD44 File Offset: 0x0014AF44
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EECD RID: 61133
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitRectilinearGridPiece_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EECE RID: 61134 RVA: 0x0014CD50 File Offset: 0x0014AF50
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EECF RID: 61135
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTransmitRectilinearGridPiece_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EED0 RID: 61136 RVA: 0x0014CD70 File Offset: 0x0014AF70
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EED1 RID: 61137
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitRectilinearGridPiece_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EED2 RID: 61138 RVA: 0x0014CD8C File Offset: 0x0014AF8C
		public override int IsA(string type)
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EED3 RID: 61139
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTransmitRectilinearGridPiece_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EED4 RID: 61140 RVA: 0x0014CDAC File Offset: 0x0014AFAC
		public new static int IsTypeOf(string type)
		{
			return vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_IsTypeOf_04(type);
		}

		// Token: 0x0600EED5 RID: 61141
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EED6 RID: 61142 RVA: 0x0014CDC8 File Offset: 0x0014AFC8
		public new vtkTransmitRectilinearGridPiece NewInstance()
		{
			vtkTransmitRectilinearGridPiece result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTransmitRectilinearGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EED7 RID: 61143
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTransmitRectilinearGridPiece_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EED8 RID: 61144 RVA: 0x0014CE24 File Offset: 0x0014B024
		public new static vtkTransmitRectilinearGridPiece SafeDownCast(vtkObjectBase o)
		{
			vtkTransmitRectilinearGridPiece vtkTransmitRectilinearGridPiece = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTransmitRectilinearGridPiece.vtkTransmitRectilinearGridPiece_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransmitRectilinearGridPiece = (vtkTransmitRectilinearGridPiece)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransmitRectilinearGridPiece.Register(null);
				}
			}
			return vtkTransmitRectilinearGridPiece;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001170 RID: 4464
		public new const string MRFullTypeName = "Kitware.VTK.vtkTransmitRectilinearGridPiece";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001171 RID: 4465
		public new static readonly string MRClassNameKey = "class vtkTransmitRectilinearGridPiece";
	}
}
