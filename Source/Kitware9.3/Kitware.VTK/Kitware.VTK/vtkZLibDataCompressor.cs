using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkZLibDataCompressor
	/// </summary>
	/// <remarks>
	///    Data compression using zlib.
	///
	/// vtkZLibDataCompressor provides a concrete vtkDataCompressor class
	/// using zlib for compressing and uncompressing data.
	/// </remarks>
	// Token: 0x02000739 RID: 1849
	public class vtkZLibDataCompressor : vtkDataCompressor
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013425 RID: 78885 RVA: 0x001B3D3B File Offset: 0x001B1F3B
		static vtkZLibDataCompressor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkZLibDataCompressor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkZLibDataCompressor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013426 RID: 78886 RVA: 0x001B3D63 File Offset: 0x001B1F63
		public vtkZLibDataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013427 RID: 78887
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkZLibDataCompressor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013428 RID: 78888 RVA: 0x001B3D74 File Offset: 0x001B1F74
		public new static vtkZLibDataCompressor New()
		{
			vtkZLibDataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkZLibDataCompressor.vtkZLibDataCompressor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkZLibDataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013429 RID: 78889 RVA: 0x001B3DC8 File Offset: 0x001B1FC8
		public vtkZLibDataCompressor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkZLibDataCompressor.vtkZLibDataCompressor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601342A RID: 78890 RVA: 0x001B3E0C File Offset: 0x001B200C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601342B RID: 78891
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkZLibDataCompressor_GetCompressionLevel_01(HandleRef pThis);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x0601342C RID: 78892 RVA: 0x001B3E18 File Offset: 0x001B2018
		public override int GetCompressionLevel()
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetCompressionLevel_01(base.GetCppThis());
		}

		// Token: 0x0601342D RID: 78893
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkZLibDataCompressor_GetMaximumCompressionSpace_02(HandleRef pThis, ulong size);

		/// <summary>
		/// Get the maximum space that may be needed to store data of the
		/// given uncompressed size after compression.  This is the minimum
		/// size of the output buffer that can be passed to the four-argument
		/// Compress method.
		/// </summary>
		// Token: 0x0601342E RID: 78894 RVA: 0x001B3E38 File Offset: 0x001B2038
		public override ulong GetMaximumCompressionSpace(ulong size)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetMaximumCompressionSpace_02(base.GetCppThis(), size);
		}

		// Token: 0x0601342F RID: 78895
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkZLibDataCompressor_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013430 RID: 78896 RVA: 0x001B3E58 File Offset: 0x001B2058
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013431 RID: 78897
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkZLibDataCompressor_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013432 RID: 78898 RVA: 0x001B3E78 File Offset: 0x001B2078
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013433 RID: 78899
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkZLibDataCompressor_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013434 RID: 78900 RVA: 0x001B3E94 File Offset: 0x001B2094
		public override int IsA(string type)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06013435 RID: 78901
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkZLibDataCompressor_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013436 RID: 78902 RVA: 0x001B3EB4 File Offset: 0x001B20B4
		public new static int IsTypeOf(string type)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_IsTypeOf_06(type);
		}

		// Token: 0x06013437 RID: 78903
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkZLibDataCompressor_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013438 RID: 78904 RVA: 0x001B3ED0 File Offset: 0x001B20D0
		public new vtkZLibDataCompressor NewInstance()
		{
			vtkZLibDataCompressor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkZLibDataCompressor.vtkZLibDataCompressor_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkZLibDataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013439 RID: 78905
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkZLibDataCompressor_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601343A RID: 78906 RVA: 0x001B3F2C File Offset: 0x001B212C
		public new static vtkZLibDataCompressor SafeDownCast(vtkObjectBase o)
		{
			vtkZLibDataCompressor vtkZLibDataCompressor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkZLibDataCompressor.vtkZLibDataCompressor_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkZLibDataCompressor = (vtkZLibDataCompressor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkZLibDataCompressor.Register(null);
				}
			}
			return vtkZLibDataCompressor;
		}

		// Token: 0x0601343B RID: 78907
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkZLibDataCompressor_SetCompressionLevel_10(HandleRef pThis, int compressionLevel);

		/// <summary>
		///  Get/Set the compression level.
		/// </summary>
		// Token: 0x0601343C RID: 78908 RVA: 0x001B3FAB File Offset: 0x001B21AB
		public override void SetCompressionLevel(int compressionLevel)
		{
			vtkZLibDataCompressor.vtkZLibDataCompressor_SetCompressionLevel_10(base.GetCppThis(), compressionLevel);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400163E RID: 5694
		public new const string MRFullTypeName = "Kitware.VTK.vtkZLibDataCompressor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400163F RID: 5695
		public new static readonly string MRClassNameKey = "class vtkZLibDataCompressor";
	}
}
