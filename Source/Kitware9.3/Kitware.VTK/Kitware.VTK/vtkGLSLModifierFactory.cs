using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGLSLModifierFactory
	/// </summary>
	/// <remarks>
	///    This class empowers developers to write and use GLSL mods eaisly in VTK.
	///
	/// For example, the mod classes could be registered via plugins.
	/// </remarks>
	// Token: 0x02000597 RID: 1431
	public class vtkGLSLModifierFactory : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FBF0 RID: 64496 RVA: 0x0015EBFF File Offset: 0x0015CDFF
		static vtkGLSLModifierFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGLSLModifierFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLSLModifierFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBF1 RID: 64497 RVA: 0x0015EC27 File Offset: 0x0015CE27
		public vtkGLSLModifierFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FBF2 RID: 64498 RVA: 0x0015EC35 File Offset: 0x0015CE35
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FBF3 RID: 64499
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGLSLModifierFactory_CreateAMod_01([MarshalAs(UnmanagedType.LPUTF8Str)] string modName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FBF4 RID: 64500 RVA: 0x0015EC40 File Offset: 0x0015CE40
		public static vtkGLSLModifierBase CreateAMod(string modName)
		{
			vtkGLSLModifierBase vtkGLSLModifierBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGLSLModifierFactory.vtkGLSLModifierFactory_CreateAMod_01(modName, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGLSLModifierBase = (vtkGLSLModifierBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGLSLModifierBase.Register(null);
				}
			}
			return vtkGLSLModifierBase;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001256 RID: 4694
		public new const string MRFullTypeName = "Kitware.VTK.vtkGLSLModifierFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001257 RID: 4695
		public new static readonly string MRClassNameKey = "class vtkGLSLModifierFactory";
	}
}
