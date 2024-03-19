using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkMotionFXCFGReader
	/// </summary>
	/// <remarks>
	///  reader for MotionFX motion definitions cfg files.
	///
	/// MotionFX files comprise of `motion`s for a collection of STL files. The
	/// motions define the transformations to apply to STL geometry to emulate
	/// motion like translation, rotation, planetary motion, etc.
	///
	/// This reader reads such a CFG file and produces a temporal output for the time
	/// range defined in the file. The resolution of time can be controlled using the
	/// `SetTimeResolution` method. The output is a multiblock dataset with blocks
	/// for each of bodies, identified by an STL file, in the cfg file.
	///
	/// The reader uses PEGTL (https://github.com/taocpp/PEGTL)
	/// to define and parse the grammar for the CFG file.
	/// </remarks>
	// Token: 0x02000177 RID: 375
	public class vtkMotionFXCFGReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004776 RID: 18294 RVA: 0x00067EDA File Offset: 0x000660DA
		static vtkMotionFXCFGReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMotionFXCFGReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMotionFXCFGReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004777 RID: 18295 RVA: 0x00067F02 File Offset: 0x00066102
		public vtkMotionFXCFGReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004778 RID: 18296
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMotionFXCFGReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004779 RID: 18297 RVA: 0x00067F10 File Offset: 0x00066110
		public new static vtkMotionFXCFGReader New()
		{
			vtkMotionFXCFGReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMotionFXCFGReader.vtkMotionFXCFGReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMotionFXCFGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600477A RID: 18298 RVA: 0x00067F64 File Offset: 0x00066164
		public vtkMotionFXCFGReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMotionFXCFGReader.vtkMotionFXCFGReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600477B RID: 18299 RVA: 0x00067FA8 File Offset: 0x000661A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600477C RID: 18300
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMotionFXCFGReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the filename.
		/// </summary>
		// Token: 0x0600477D RID: 18301 RVA: 0x00067FB4 File Offset: 0x000661B4
		public string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMotionFXCFGReader.vtkMotionFXCFGReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600477E RID: 18302
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMotionFXCFGReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600477F RID: 18303 RVA: 0x00067FF0 File Offset: 0x000661F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06004780 RID: 18304
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMotionFXCFGReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004781 RID: 18305 RVA: 0x00068010 File Offset: 0x00066210
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06004782 RID: 18306
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMotionFXCFGReader_GetTimeResolution_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the time resolution for timesteps produced by the reader.
		/// </summary>
		// Token: 0x06004783 RID: 18307 RVA: 0x0006802C File Offset: 0x0006622C
		public virtual int GetTimeResolution()
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_GetTimeResolution_04(base.GetCppThis());
		}

		// Token: 0x06004784 RID: 18308
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMotionFXCFGReader_GetTimeResolutionMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the time resolution for timesteps produced by the reader.
		/// </summary>
		// Token: 0x06004785 RID: 18309 RVA: 0x0006804C File Offset: 0x0006624C
		public virtual int GetTimeResolutionMaxValue()
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_GetTimeResolutionMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06004786 RID: 18310
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMotionFXCFGReader_GetTimeResolutionMinValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the time resolution for timesteps produced by the reader.
		/// </summary>
		// Token: 0x06004787 RID: 18311 RVA: 0x0006806C File Offset: 0x0006626C
		public virtual int GetTimeResolutionMinValue()
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_GetTimeResolutionMinValue_06(base.GetCppThis());
		}

		// Token: 0x06004788 RID: 18312
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMotionFXCFGReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004789 RID: 18313 RVA: 0x0006808C File Offset: 0x0006628C
		public override int IsA(string type)
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600478A RID: 18314
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMotionFXCFGReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600478B RID: 18315 RVA: 0x000680AC File Offset: 0x000662AC
		public new static int IsTypeOf(string type)
		{
			return vtkMotionFXCFGReader.vtkMotionFXCFGReader_IsTypeOf_08(type);
		}

		// Token: 0x0600478C RID: 18316
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMotionFXCFGReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600478D RID: 18317 RVA: 0x000680C8 File Offset: 0x000662C8
		public new vtkMotionFXCFGReader NewInstance()
		{
			vtkMotionFXCFGReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMotionFXCFGReader.vtkMotionFXCFGReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMotionFXCFGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600478E RID: 18318
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMotionFXCFGReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600478F RID: 18319 RVA: 0x00068124 File Offset: 0x00066324
		public new static vtkMotionFXCFGReader SafeDownCast(vtkObjectBase o)
		{
			vtkMotionFXCFGReader vtkMotionFXCFGReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMotionFXCFGReader.vtkMotionFXCFGReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMotionFXCFGReader = (vtkMotionFXCFGReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMotionFXCFGReader.Register(null);
				}
			}
			return vtkMotionFXCFGReader;
		}

		// Token: 0x06004790 RID: 18320
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMotionFXCFGReader_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fname);

		/// <summary>
		/// Get/Set the filename.
		/// </summary>
		// Token: 0x06004791 RID: 18321 RVA: 0x000681A3 File Offset: 0x000663A3
		public void SetFileName(string fname)
		{
			vtkMotionFXCFGReader.vtkMotionFXCFGReader_SetFileName_12(base.GetCppThis(), fname);
		}

		// Token: 0x06004792 RID: 18322
		[DllImport("Kitware.VTK.IOMotionFX.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMotionFXCFGReader_SetTimeResolution_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the time resolution for timesteps produced by the reader.
		/// </summary>
		// Token: 0x06004793 RID: 18323 RVA: 0x000681B3 File Offset: 0x000663B3
		public virtual void SetTimeResolution(int _arg)
		{
			vtkMotionFXCFGReader.vtkMotionFXCFGReader_SetTimeResolution_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400073F RID: 1855
		public new const string MRFullTypeName = "Kitware.VTK.vtkMotionFXCFGReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000740 RID: 1856
		public new static readonly string MRClassNameKey = "class vtkMotionFXCFGReader";
	}
}
