using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// Get vtkDataArraySelection instance to select cell arrays to read.
	/// </summary>
	// Token: 0x0200012C RID: 300
	public class vtkVeraOutReader : vtkRectilinearGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003C93 RID: 15507 RVA: 0x0005862F File Offset: 0x0005682F
		static vtkVeraOutReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVeraOutReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVeraOutReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003C94 RID: 15508 RVA: 0x00058657 File Offset: 0x00056857
		public vtkVeraOutReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003C95 RID: 15509
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVeraOutReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06003C96 RID: 15510 RVA: 0x00058668 File Offset: 0x00056868
		public new static vtkVeraOutReader New()
		{
			vtkVeraOutReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVeraOutReader.vtkVeraOutReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVeraOutReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x000586BC File Offset: 0x000568BC
		public vtkVeraOutReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVeraOutReader.vtkVeraOutReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003C98 RID: 15512 RVA: 0x00058700 File Offset: 0x00056900
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003C99 RID: 15513
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVeraOutReader_GetCellDataArraySelection_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get vtkDataArraySelection instance to select cell arrays to read.
		/// </summary>
		// Token: 0x06003C9A RID: 15514 RVA: 0x0005870C File Offset: 0x0005690C
		public vtkDataArraySelection GetCellDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVeraOutReader.vtkVeraOutReader_GetCellDataArraySelection_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06003C9B RID: 15515
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVeraOutReader_GetFieldDataArraySelection_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get vtkDataArraySelection instance to select field arrays to read.
		/// </summary>
		// Token: 0x06003C9C RID: 15516 RVA: 0x0005877C File Offset: 0x0005697C
		public vtkDataArraySelection GetFieldDataArraySelection()
		{
			vtkDataArraySelection vtkDataArraySelection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVeraOutReader.vtkVeraOutReader_GetFieldDataArraySelection_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArraySelection = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArraySelection.Register(null);
				}
			}
			return vtkDataArraySelection;
		}

		// Token: 0x06003C9D RID: 15517
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVeraOutReader_GetFileName_03(HandleRef pThis);

		// Token: 0x06003C9E RID: 15518 RVA: 0x000587EC File Offset: 0x000569EC
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkVeraOutReader.vtkVeraOutReader_GetFileName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06003C9F RID: 15519
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVeraOutReader_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Override GetMTime because of array selector.
		/// </summary>
		// Token: 0x06003CA0 RID: 15520 RVA: 0x00058828 File Offset: 0x00056A28
		public override ulong GetMTime()
		{
			return vtkVeraOutReader.vtkVeraOutReader_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06003CA1 RID: 15521
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVeraOutReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06003CA2 RID: 15522 RVA: 0x00058848 File Offset: 0x00056A48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVeraOutReader.vtkVeraOutReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06003CA3 RID: 15523
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVeraOutReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06003CA4 RID: 15524 RVA: 0x00058868 File Offset: 0x00056A68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVeraOutReader.vtkVeraOutReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06003CA5 RID: 15525
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVeraOutReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00058884 File Offset: 0x00056A84
		public override int IsA(string type)
		{
			return vtkVeraOutReader.vtkVeraOutReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06003CA7 RID: 15527
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVeraOutReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06003CA8 RID: 15528 RVA: 0x000588A4 File Offset: 0x00056AA4
		public new static int IsTypeOf(string type)
		{
			return vtkVeraOutReader.vtkVeraOutReader_IsTypeOf_08(type);
		}

		// Token: 0x06003CA9 RID: 15529
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVeraOutReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06003CAA RID: 15530 RVA: 0x000588C0 File Offset: 0x00056AC0
		public new vtkVeraOutReader NewInstance()
		{
			vtkVeraOutReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVeraOutReader.vtkVeraOutReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVeraOutReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003CAB RID: 15531
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVeraOutReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06003CAC RID: 15532 RVA: 0x0005891C File Offset: 0x00056B1C
		public new static vtkVeraOutReader SafeDownCast(vtkObjectBase o)
		{
			vtkVeraOutReader vtkVeraOutReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVeraOutReader.vtkVeraOutReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVeraOutReader = (vtkVeraOutReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVeraOutReader.Register(null);
				}
			}
			return vtkVeraOutReader;
		}

		// Token: 0x06003CAD RID: 15533
		[DllImport("Kitware.VTK.IOVeraOut.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVeraOutReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		// Token: 0x06003CAE RID: 15534 RVA: 0x0005899B File Offset: 0x00056B9B
		public virtual void SetFileName(string _arg)
		{
			vtkVeraOutReader.vtkVeraOutReader_SetFileName_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000691 RID: 1681
		public new const string MRFullTypeName = "Kitware.VTK.vtkVeraOutReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000692 RID: 1682
		public new static readonly string MRClassNameKey = "class vtkVeraOutReader";
	}
}
