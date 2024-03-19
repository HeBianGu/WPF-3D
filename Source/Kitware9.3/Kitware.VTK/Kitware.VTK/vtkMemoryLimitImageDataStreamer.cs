using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMemoryLimitImageDataStreamer
	/// </summary>
	/// <remarks>
	///    Initiates streaming on image data.
	///
	/// To satisfy a request, this filter calls update on its input
	/// many times with smaller update extents.  All processing up stream
	/// streams smaller pieces.
	/// </remarks>
	// Token: 0x0200046D RID: 1133
	public class vtkMemoryLimitImageDataStreamer : vtkImageDataStreamer
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D1F6 RID: 53750 RVA: 0x00124277 File Offset: 0x00122477
		static vtkMemoryLimitImageDataStreamer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMemoryLimitImageDataStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMemoryLimitImageDataStreamer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1F7 RID: 53751 RVA: 0x0012429F File Offset: 0x0012249F
		public vtkMemoryLimitImageDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D1F8 RID: 53752
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMemoryLimitImageDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1F9 RID: 53753 RVA: 0x001242B0 File Offset: 0x001224B0
		public new static vtkMemoryLimitImageDataStreamer New()
		{
			vtkMemoryLimitImageDataStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1FA RID: 53754 RVA: 0x00124304 File Offset: 0x00122504
		public vtkMemoryLimitImageDataStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1FB RID: 53755 RVA: 0x00124348 File Offset: 0x00122548
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D1FC RID: 53756
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMemoryLimitImageDataStreamer_GetMemoryLimit_01(HandleRef pThis);

		/// <summary>
		/// Set / Get the memory limit in kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x0600D1FD RID: 53757 RVA: 0x00124354 File Offset: 0x00122554
		public virtual uint GetMemoryLimit()
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_GetMemoryLimit_01(base.GetCppThis());
		}

		// Token: 0x0600D1FE RID: 53758
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1FF RID: 53759 RVA: 0x00124374 File Offset: 0x00122574
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D200 RID: 53760
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D201 RID: 53761 RVA: 0x00124394 File Offset: 0x00122594
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D202 RID: 53762
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMemoryLimitImageDataStreamer_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D203 RID: 53763 RVA: 0x001243B0 File Offset: 0x001225B0
		public override int IsA(string type)
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D204 RID: 53764
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMemoryLimitImageDataStreamer_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D205 RID: 53765 RVA: 0x001243D0 File Offset: 0x001225D0
		public new static int IsTypeOf(string type)
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_IsTypeOf_05(type);
		}

		// Token: 0x0600D206 RID: 53766
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMemoryLimitImageDataStreamer_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D207 RID: 53767 RVA: 0x001243EC File Offset: 0x001225EC
		public new vtkMemoryLimitImageDataStreamer NewInstance()
		{
			vtkMemoryLimitImageDataStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D208 RID: 53768
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMemoryLimitImageDataStreamer_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D209 RID: 53769 RVA: 0x00124448 File Offset: 0x00122648
		public new static vtkMemoryLimitImageDataStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkMemoryLimitImageDataStreamer vtkMemoryLimitImageDataStreamer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMemoryLimitImageDataStreamer = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMemoryLimitImageDataStreamer.Register(null);
				}
			}
			return vtkMemoryLimitImageDataStreamer;
		}

		// Token: 0x0600D20A RID: 53770
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMemoryLimitImageDataStreamer_SetMemoryLimit_09(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set / Get the memory limit in kibibytes (1024 bytes).
		/// </summary>
		// Token: 0x0600D20B RID: 53771 RVA: 0x001244C7 File Offset: 0x001226C7
		public virtual void SetMemoryLimit(uint _arg)
		{
			vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_SetMemoryLimit_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F7B RID: 3963
		public new const string MRFullTypeName = "Kitware.VTK.vtkMemoryLimitImageDataStreamer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F7C RID: 3964
		public new static readonly string MRClassNameKey = "class vtkMemoryLimitImageDataStreamer";
	}
}
