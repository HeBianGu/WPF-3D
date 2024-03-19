using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLZ4DataCompressor
	/// </summary>
	/// <remarks>
	///    Data compression using LZ4.
	///
	/// vtkLZ4DataCompressor provides a concrete vtkDataCompressor class
	/// using LZ4 for compressing and uncompressing data.
	/// </remarks>
	// Token: 0x0200072E RID: 1838
	public class vtkLZ4DataCompressor : vtkDataCompressor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060132F0 RID: 78576 RVA: 0x001B1FD7 File Offset: 0x001B01D7
		static vtkLZ4DataCompressor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLZ4DataCompressor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLZ4DataCompressor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060132F1 RID: 78577 RVA: 0x001B1FFF File Offset: 0x001B01FF
		public vtkLZ4DataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060132F2 RID: 78578
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLZ4DataCompressor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132F3 RID: 78579 RVA: 0x001B2010 File Offset: 0x001B0210
		public new static vtkLZ4DataCompressor New()
		{
			vtkLZ4DataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLZ4DataCompressor.vtkLZ4DataCompressor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLZ4DataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060132F4 RID: 78580 RVA: 0x001B2064 File Offset: 0x001B0264
		public vtkLZ4DataCompressor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLZ4DataCompressor.vtkLZ4DataCompressor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060132F5 RID: 78581 RVA: 0x001B20A8 File Offset: 0x001B02A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060132F6 RID: 78582
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZ4DataCompressor_GetAccelerationLevel_01(HandleRef pThis);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x060132F7 RID: 78583 RVA: 0x001B20B4 File Offset: 0x001B02B4
		public virtual int GetAccelerationLevel()
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetAccelerationLevel_01(base.GetCppThis());
		}

		// Token: 0x060132F8 RID: 78584
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZ4DataCompressor_GetAccelerationLevelMaxValue_02(HandleRef pThis);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x060132F9 RID: 78585 RVA: 0x001B20D4 File Offset: 0x001B02D4
		public virtual int GetAccelerationLevelMaxValue()
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetAccelerationLevelMaxValue_02(base.GetCppThis());
		}

		// Token: 0x060132FA RID: 78586
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZ4DataCompressor_GetAccelerationLevelMinValue_03(HandleRef pThis);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x060132FB RID: 78587 RVA: 0x001B20F4 File Offset: 0x001B02F4
		public virtual int GetAccelerationLevelMinValue()
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetAccelerationLevelMinValue_03(base.GetCppThis());
		}

		// Token: 0x060132FC RID: 78588
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZ4DataCompressor_GetCompressionLevel_04(HandleRef pThis);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x060132FD RID: 78589 RVA: 0x001B2114 File Offset: 0x001B0314
		public override int GetCompressionLevel()
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetCompressionLevel_04(base.GetCppThis());
		}

		// Token: 0x060132FE RID: 78590
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLZ4DataCompressor_GetMaximumCompressionSpace_05(HandleRef pThis, ulong size);

		/// <summary>
		///  Get the maximum space that may be needed to store data of the
		///  given uncompressed size after compression.  This is the minimum
		///  size of the output buffer that can be passed to the four-argument
		///  Compress method.
		/// </summary>
		// Token: 0x060132FF RID: 78591 RVA: 0x001B2134 File Offset: 0x001B0334
		public override ulong GetMaximumCompressionSpace(ulong size)
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetMaximumCompressionSpace_05(base.GetCppThis(), size);
		}

		// Token: 0x06013300 RID: 78592
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLZ4DataCompressor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013301 RID: 78593 RVA: 0x001B2154 File Offset: 0x001B0354
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06013302 RID: 78594
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLZ4DataCompressor_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013303 RID: 78595 RVA: 0x001B2174 File Offset: 0x001B0374
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06013304 RID: 78596
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZ4DataCompressor_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013305 RID: 78597 RVA: 0x001B2190 File Offset: 0x001B0390
		public override int IsA(string type)
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06013306 RID: 78598
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLZ4DataCompressor_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013307 RID: 78599 RVA: 0x001B21B0 File Offset: 0x001B03B0
		public new static int IsTypeOf(string type)
		{
			return vtkLZ4DataCompressor.vtkLZ4DataCompressor_IsTypeOf_09(type);
		}

		// Token: 0x06013308 RID: 78600
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLZ4DataCompressor_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013309 RID: 78601 RVA: 0x001B21CC File Offset: 0x001B03CC
		public new vtkLZ4DataCompressor NewInstance()
		{
			vtkLZ4DataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLZ4DataCompressor.vtkLZ4DataCompressor_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLZ4DataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601330A RID: 78602
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLZ4DataCompressor_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601330B RID: 78603 RVA: 0x001B2228 File Offset: 0x001B0428
		public new static vtkLZ4DataCompressor SafeDownCast(vtkObjectBase o)
		{
			vtkLZ4DataCompressor vtkLZ4DataCompressor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLZ4DataCompressor.vtkLZ4DataCompressor_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLZ4DataCompressor = (vtkLZ4DataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLZ4DataCompressor.Register(null);
				}
			}
			return vtkLZ4DataCompressor;
		}

		// Token: 0x0601330C RID: 78604
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLZ4DataCompressor_SetAccelerationLevel_13(HandleRef pThis, int _arg);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x0601330D RID: 78605 RVA: 0x001B22A7 File Offset: 0x001B04A7
		public virtual void SetAccelerationLevel(int _arg)
		{
			vtkLZ4DataCompressor.vtkLZ4DataCompressor_SetAccelerationLevel_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601330E RID: 78606
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLZ4DataCompressor_SetCompressionLevel_14(HandleRef pThis, int compressionLevel);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x0601330F RID: 78607 RVA: 0x001B22B7 File Offset: 0x001B04B7
		public override void SetCompressionLevel(int compressionLevel)
		{
			vtkLZ4DataCompressor.vtkLZ4DataCompressor_SetCompressionLevel_14(base.GetCppThis(), compressionLevel);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400162A RID: 5674
		public new const string MRFullTypeName = "Kitware.VTK.vtkLZ4DataCompressor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400162B RID: 5675
		public new static readonly string MRClassNameKey = "class vtkLZ4DataCompressor";
	}
}
