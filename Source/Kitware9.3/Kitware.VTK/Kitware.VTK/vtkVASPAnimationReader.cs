using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVASPAnimationReader
	/// </summary>
	/// <remarks>
	///    Reader for VASP animation files.
	///
	///
	/// Reads VASP animation files (e.g. NPT_Z_ANIMATE.out).
	/// </remarks>
	// Token: 0x020001D1 RID: 465
	public class vtkVASPAnimationReader : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060059B0 RID: 22960 RVA: 0x00081A53 File Offset: 0x0007FC53
		static vtkVASPAnimationReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVASPAnimationReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVASPAnimationReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060059B1 RID: 22961 RVA: 0x00081A7B File Offset: 0x0007FC7B
		public vtkVASPAnimationReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060059B2 RID: 22962
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPAnimationReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059B3 RID: 22963 RVA: 0x00081A8C File Offset: 0x0007FC8C
		public new static vtkVASPAnimationReader New()
		{
			vtkVASPAnimationReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVASPAnimationReader.vtkVASPAnimationReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVASPAnimationReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059B4 RID: 22964 RVA: 0x00081AE0 File Offset: 0x0007FCE0
		public vtkVASPAnimationReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVASPAnimationReader.vtkVASPAnimationReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060059B5 RID: 22965 RVA: 0x00081B24 File Offset: 0x0007FD24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060059B6 RID: 22966
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPAnimationReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// The name of the file to read.
		/// </summary>
		// Token: 0x060059B7 RID: 22967 RVA: 0x00081B30 File Offset: 0x0007FD30
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkVASPAnimationReader.vtkVASPAnimationReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060059B8 RID: 22968
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVASPAnimationReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059B9 RID: 22969 RVA: 0x00081B6C File Offset: 0x0007FD6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVASPAnimationReader.vtkVASPAnimationReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060059BA RID: 22970
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVASPAnimationReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059BB RID: 22971 RVA: 0x00081B8C File Offset: 0x0007FD8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVASPAnimationReader.vtkVASPAnimationReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060059BC RID: 22972
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVASPAnimationReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059BD RID: 22973 RVA: 0x00081BA8 File Offset: 0x0007FDA8
		public override int IsA(string type)
		{
			return vtkVASPAnimationReader.vtkVASPAnimationReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060059BE RID: 22974
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVASPAnimationReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059BF RID: 22975 RVA: 0x00081BC8 File Offset: 0x0007FDC8
		public new static int IsTypeOf(string type)
		{
			return vtkVASPAnimationReader.vtkVASPAnimationReader_IsTypeOf_05(type);
		}

		// Token: 0x060059C0 RID: 22976
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPAnimationReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059C1 RID: 22977 RVA: 0x00081BE4 File Offset: 0x0007FDE4
		public new vtkVASPAnimationReader NewInstance()
		{
			vtkVASPAnimationReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVASPAnimationReader.vtkVASPAnimationReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVASPAnimationReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060059C2 RID: 22978
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVASPAnimationReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059C3 RID: 22979 RVA: 0x00081C40 File Offset: 0x0007FE40
		public new static vtkVASPAnimationReader SafeDownCast(vtkObjectBase o)
		{
			vtkVASPAnimationReader vtkVASPAnimationReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVASPAnimationReader.vtkVASPAnimationReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVASPAnimationReader = (vtkVASPAnimationReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVASPAnimationReader.Register(null);
				}
			}
			return vtkVASPAnimationReader;
		}

		// Token: 0x060059C4 RID: 22980
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVASPAnimationReader_SetFileName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the file to read.
		/// </summary>
		// Token: 0x060059C5 RID: 22981 RVA: 0x00081CBF File Offset: 0x0007FEBF
		public virtual void SetFileName(string _arg)
		{
			vtkVASPAnimationReader.vtkVASPAnimationReader_SetFileName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000869 RID: 2153
		public new const string MRFullTypeName = "Kitware.VTK.vtkVASPAnimationReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400086A RID: 2154
		public new static readonly string MRClassNameKey = "class vtkVASPAnimationReader";
	}
}
