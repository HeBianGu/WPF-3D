using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSLACParticleReader
	///
	///
	///
	/// A reader for a data format used by Omega3p, Tau3p, and several other tools
	/// used at the Standford Linear Accelerator Center (SLAC).  The underlying
	/// format uses netCDF to store arrays, but also imposes some conventions
	/// to store a list of particles in 3D space.
	///
	/// This reader supports pieces, but in actuality only loads anything in
	/// piece 0.  All other pieces are empty.
	///
	/// </summary>
	// Token: 0x02000174 RID: 372
	public class vtkSLACParticleReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600470A RID: 18186 RVA: 0x000674ED File Offset: 0x000656ED
		static vtkSLACParticleReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSLACParticleReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSLACParticleReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600470B RID: 18187 RVA: 0x00067515 File Offset: 0x00065715
		public vtkSLACParticleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600470C RID: 18188
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACParticleReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600470D RID: 18189 RVA: 0x00067524 File Offset: 0x00065724
		public new static vtkSLACParticleReader New()
		{
			vtkSLACParticleReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACParticleReader.vtkSLACParticleReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600470E RID: 18190 RVA: 0x00067578 File Offset: 0x00065778
		public vtkSLACParticleReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSLACParticleReader.vtkSLACParticleReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600470F RID: 18191 RVA: 0x000675BC File Offset: 0x000657BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004710 RID: 18192
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACParticleReader_CanReadFile_01([MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		/// Returns true if the given file can be read by this reader.
		/// </summary>
		// Token: 0x06004711 RID: 18193 RVA: 0x000675C8 File Offset: 0x000657C8
		public static int CanReadFile(string filename)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_CanReadFile_01(filename);
		}

		// Token: 0x06004712 RID: 18194
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACParticleReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004713 RID: 18195 RVA: 0x000675E4 File Offset: 0x000657E4
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSLACParticleReader.vtkSLACParticleReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004714 RID: 18196
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSLACParticleReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004715 RID: 18197 RVA: 0x00067620 File Offset: 0x00065820
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06004716 RID: 18198
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSLACParticleReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004717 RID: 18199 RVA: 0x00067640 File Offset: 0x00065840
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06004718 RID: 18200
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACParticleReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004719 RID: 18201 RVA: 0x0006765C File Offset: 0x0006585C
		public override int IsA(string type)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600471A RID: 18202
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSLACParticleReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600471B RID: 18203 RVA: 0x0006767C File Offset: 0x0006587C
		public new static int IsTypeOf(string type)
		{
			return vtkSLACParticleReader.vtkSLACParticleReader_IsTypeOf_06(type);
		}

		// Token: 0x0600471C RID: 18204
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACParticleReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600471D RID: 18205 RVA: 0x00067698 File Offset: 0x00065898
		public new vtkSLACParticleReader NewInstance()
		{
			vtkSLACParticleReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACParticleReader.vtkSLACParticleReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600471E RID: 18206
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSLACParticleReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600471F RID: 18207 RVA: 0x000676F4 File Offset: 0x000658F4
		public new static vtkSLACParticleReader SafeDownCast(vtkObjectBase o)
		{
			vtkSLACParticleReader vtkSLACParticleReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSLACParticleReader.vtkSLACParticleReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSLACParticleReader = (vtkSLACParticleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSLACParticleReader.Register(null);
				}
			}
			return vtkSLACParticleReader;
		}

		// Token: 0x06004720 RID: 18208
		[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSLACParticleReader_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004721 RID: 18209 RVA: 0x00067773 File Offset: 0x00065973
		public virtual void SetFileName(string _arg)
		{
			vtkSLACParticleReader.vtkSLACParticleReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000737 RID: 1847
		public new const string MRFullTypeName = "Kitware.VTK.vtkSLACParticleReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000738 RID: 1848
		public new static readonly string MRClassNameKey = "class vtkSLACParticleReader";
	}
}
